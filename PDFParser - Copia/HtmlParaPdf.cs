using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iText.Html2pdf;


namespace PDFParser
{
    public partial class HtmlParaPdf : UserControl
    {
        public HtmlParaPdf()
        {
            InitializeComponent();
        }

        private void btnSelecionarHtml_Click(object sender, EventArgs e)
        {
            if (HtmlFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                foreach (String file in HtmlFileDialog.FileNames)
                {
                   lblDocumentoSelecionado2.Text+=file;
                }                    

                this.btnSelecionarHtml.BackColor = Color.Green;
                
            }
        }

        private void converterHtml_Click(object sender, EventArgs e)
        {
            
            // Funciona com múltiplos Documentos!!
            // Corrigido bug. Agora a conversão é feita na própria pasta

            foreach (string file in HtmlFileDialog.FileNames)
            {
                string origem = file;
                string pdfDest = file + ".pdf";

                HtmlConverter.ConvertToPdf(new FileStream(origem, FileMode.Open, FileAccess.Read, FileShare.Read), new FileStream(pdfDest, FileMode.Create));
            }
            lblDocumentoSelecionado2.Text = "Documentos convertidos com sucesso";            

        }
    }
}
