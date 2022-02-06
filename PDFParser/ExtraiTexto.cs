using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//componentes do Itex7
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace PDFParser
{
    public partial class ExtraiTexto : UserControl
    {
        public ExtraiTexto()
        {
            InitializeComponent();
        }

        private void ExtraiTexto_Load(object sender, EventArgs e)
        {

        }

        private void btnExtraiTextoPdf_Click(object sender, EventArgs e)
        {
            selecionarArquivo.Filter = "Arquivo pdf | *.pdf";
            if (selecionarArquivo.ShowDialog() != DialogResult.Cancel)
            {
                lblDocSelecionado.Text = "Documento selecionado: \n" + selecionarArquivo.FileName;

                rtbTexto.Text = ExtraiTextodePdf(selecionarArquivo.FileName);
            }
        }

        static String ExtraiTextodePdf(string nomeDoArquivo)
        {
            string resultado = null;
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };


            PdfReader reader = new PdfReader(nomeDoArquivo);
            PdfDocument pdfDoc = new PdfDocument(reader);

            for (int pagina = 1; pagina < pdfDoc.GetNumberOfPages(); pagina++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string conteudoDaPagina = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(pagina), strategy);
                resultado += conteudoDaPagina;
            }
            pdfDoc.Close();
            reader.Close();
                        
            return resultado;
        }

    }
}
