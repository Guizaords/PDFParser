using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Itext7
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace PDFParser
{
    public partial class SeparaPagnina : UserControl
    {
        private List<int> todasAsPaginas = new List<int>();
        public SeparaPagnina()
        {
            InitializeComponent();
        }

        private void btnSelecionaPdf1_Click(object sender, EventArgs e)
        {
            selecionarArquivoASeparar.Filter = "Arquivo pdf | *.pdf";
            if (selecionarArquivoASeparar.ShowDialog() != DialogResult.Cancel)                
            {
                foreach (String file in selecionarArquivoASeparar.FileNames)
                {
                    //lblPdfSelecionado.Text = "Documento selecionado: \n" + file;
                    lblPdfSelecionado.Text += file+"\n";
                    this.btnSepararPagina.BackColor = Color.Green;
                }
            }
        }

        public void SeparaPaginas()
        {   /*
            if (lblPdfSelecionado.Text.Contains("1 - Selecione um arquivo .pdf"))

            {
                MessageBox.Show("Por favor selecione um arquivo .pdf", "POR FAVOR SELECIONE SEU PDF");
                return;
            }*/


            var inputTxt = textBox1.Text.ToString().ToLower();

            todasAsPaginas.Clear();

            foreach (var filename in selecionarArquivoASeparar.FileNames)
            {
                // abre o pdf em modo de leitura e copia as páginas para o pdf em modo de escrita
                PdfDocument srcPdf = new PdfDocument(new PdfReader(filename));
                //PdfDocument pdfDocument = new PdfDocument(new PdfWriter(filename + "copy.pdf"));


                try
                {
                    for (int pagina = 1; pagina <= srcPdf.GetNumberOfPages(); pagina++)

                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string conteudoDaPagina = PdfTextExtractor.GetTextFromPage(srcPdf.GetPage(pagina), strategy);

                        if (conteudoDaPagina.ToLower().Contains(inputTxt))
                        {

                            Console.WriteLine(inputTxt + " encontrado na página " + pagina + "\n");
                            todasAsPaginas.Add(pagina);
                        }
                        else
                        {
                            //Console.WriteLine(inputTxt + "  encontrado na página " + pagina + "\n");
                        }

                    }

                    if(todasAsPaginas.Count > 0)
                    {
                        PdfDocument pdfDocument = new PdfDocument(new PdfWriter(filename + "copy.pdf"));

                        lblPaginasExtraidas.Text = "Termo " + inputTxt.ToUpper() + " encontrado nas páginas \n"
                       + String.Join(" , ", todasAsPaginas) + " e salvo em \n" + selecionarArquivoASeparar.FileName + "copy.pdf";

                        srcPdf.CopyPagesTo(todasAsPaginas, pdfDocument);

                        pdfDocument.Close();
                        srcPdf.Close();
                        todasAsPaginas.Clear();
                    }
                    else
                    {
                        srcPdf.Close();
                        todasAsPaginas.Clear();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("erro na pagina " + ex);
                    //pdfDocument.Close();
                    srcPdf.Close();
                    return;
                }
            }
        }
            
            

        private void btnSepararPagina_Click(object sender, EventArgs e)
        {
            SeparaPaginas();
        }

        private void selecionarArquivoASeparar_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
