using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

//ItextOCR

using iText.Kernel.Pdf;
using iText.Pdfocr;
using iText.Pdfocr.Tesseract4;

//GhostScript
using GhostscriptSharp;



namespace PDFParser
{
    public partial class ConvertePesquisavel : UserControl
    {
        private static readonly Tesseract4OcrEngineProperties tesseract4OcrEngineProperties = new Tesseract4OcrEngineProperties();
        public static string PATH_ROOT = System.Environment.CurrentDirectory;
        private static string TESS_DATA_FOLDER = @"TESSDATA";
        public  static string DEST =  @"TEMP";
        private const string DEFAULT_RGB_COLOR_PROFILE_PATH = @"profiles\sRGB_CS_profile.icm";


        private string OUTPUT_PDF;
        private static IList<FileInfo> LIST_IMAGES_OCR = new List<FileInfo>();


        public ConvertePesquisavel()
        {
            InitializeComponent();
        }

        private void ConvertePesquisavel_Load(object sender, EventArgs e)
        {

        }

        private void btnOcrSelecionarArquivo_Click(object sender, EventArgs e)
        {
            ocrFileDialog.Filter = "Arquivo pdf | *.pdf";

            if (ocrFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblOcrArquivoSelecionado.Text = "Documento selecionado: \n" + ocrFileDialog.FileName;
                this.btnConverterOcr.BackColor = Color.Green;
                lblConvertido.Text = "";
            }
        }

        void OcrConvert()
        {
            var tesseractReader = new Tesseract4LibOcrEngine(tesseract4OcrEngineProperties);
            tesseract4OcrEngineProperties.SetPathToTessData(new FileInfo(TESS_DATA_FOLDER));
            var properties = new OcrPdfCreatorProperties();
            properties.SetPdfLang("eng, por");

            var ocrPdfCreator = new OcrPdfCreator(tesseractReader, properties);

            OUTPUT_PDF = ocrFileDialog.FileName + "ocr.pdf";
            LIST_IMAGES_OCR.Clear();

            lblConvertido.Text = $"Iniciando a conversão do arquivo\n {OUTPUT_PDF}. \nConsulte na mesma pasta de origem";


            // Cria o diretório para armazenar os dados
            if (!Directory.Exists(DEST))
            {
                Directory.CreateDirectory(DEST);
            }

            //Chama a função antes do ocr
            GerarVariasPaginas(DEST);

            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo(DEST);
            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();

            lblConvertido.Text = "Aguarde, convertendo seu pdf";

            foreach (FileInfo f in fiArr)
            {

                LIST_IMAGES_OCR.Add(f);
                
            }

            try
            {
                using (var writer = new PdfWriter(OUTPUT_PDF))
                {
                    ocrPdfCreator.CreatePdfA(LIST_IMAGES_OCR, writer, GetRgbPdfOutputIntent()).Close();
                }
                lblConvertido.Text = $"Documento\n {OUTPUT_PDF}\n foi convertido com sucesso!!";

            }
            catch (Exception)
            {                              
                
                MessageBox.Show("Seu arquivo não foi convertido. Por favor limpe a pasta TEMP");
                return;
                
            }            

        }

        private void ocrFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnConverterOcr_Click(object sender, EventArgs e)
        {
            if (lblOcrArquivoSelecionado.Text.Contains("Arquivo Selecionado:"))

            {
                MessageBox.Show("Por favor selecione um arquivo .pdf", "POR FAVOR SELECIONE SEU PDF");
                return;
            }

            else
            {
                OcrConvert();
                DirectoryInfo di = new DirectoryInfo(DEST);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }

                //lblConvertido.Text = $"Documento\n {OUTPUT_PDF}\n foi convertido com sucesso!!";
                lblOcrArquivoSelecionado.Text = "Arquivo Selecionado:";
            }
        }

        
        private void lblConvertido_Click(object sender, EventArgs e)
        {

        }

        static PdfOutputIntent GetRgbPdfOutputIntent()
        {
            Stream @is = new FileStream(DEFAULT_RGB_COLOR_PROFILE_PATH, FileMode.Open, FileAccess.Read);
            return new PdfOutputIntent("", "", "", "sRGB IEC61966-2.1", @is);
        }

        //[Test]
        public void GerarVariasPaginas(string DEST)
        {
            string pdfToImage = ocrFileDialog.FileName.ToString();

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(pdfToImage));

            int firstPage = 1;
            int lastPage = pdfDoc.GetNumberOfPages();

            GhostscriptSettings gs = new GhostscriptSettings();
            

            gs.Page.Start = firstPage;
            gs.Page.End = lastPage;

            lblConvertido.Text = $"Aguarde... convertendo o documento\n {OUTPUT_PDF}\n em formato pesquisável";

            GhostscriptWrapper.GeneratePageThumbs(pdfToImage,
                DEST+@"/temp%d.jpg", firstPage, lastPage, 200, 200);

            pdfDoc.Close();
        }


    }
}
