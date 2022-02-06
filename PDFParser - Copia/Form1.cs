using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFParser
{
    public partial class PdfParser : Form
    {


        public PdfParser()
        {
            InitializeComponent();
            painelLateral.Height = btnHome.Height;
            principal1.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnExtrairTexto_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnExtrairTexto.Height;
            extraiTexto1.BringToFront();
            
        }

        private void btnSepararPdf_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnSepararPdf.Height;
            separaPagnina1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnHome.Height;
            principal1.BringToFront();
            label1.BringToFront();
            label1.Text = "Funcionalidades Disponíveis: \n\n" +
                "Extrai texto: \npermite a extração do texto de um arquivo .pdf (ok)\n\n" +
                "Separar página: \nsepara as páginas conforme um termo pesquisado (ok)\n\n" +
                "Converter documento não pesquisável em pesquisável:\n" +
                "Converte .pdf não pesquisável utilizando OCR (funcionando com bugs)\n\n" +
                "Converte .html em .pdf: Converte arquivo em html (ex. despachos SEI) em .pdf (funcionando com bugs quando há tabelas)\n\n" +
                "Funcionalidades em Progresso:\n" +
                "Salvar registros em um arquivo .xlsx\n" +
                "Iterar sobre multiplos arquivos de um diretorio\n" +


        }

        private void btnConverteOcr_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnConverteOcr.Height;
            convertePesquisavel1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConverterHtml_Click(object sender, EventArgs e)
        {
            painelLateral.Height = btnConverteOcr.Height;
            htmlParaPdf1.BringToFront();
        }
    }
}
