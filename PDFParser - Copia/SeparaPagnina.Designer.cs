
namespace PDFParser
{
    partial class SeparaPagnina
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelecionaPdf1 = new System.Windows.Forms.Button();
            this.lblPdfSelecionado = new System.Windows.Forms.Label();
            this.btnSepararPagina = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDigitar = new System.Windows.Forms.Label();
            this.selecionarArquivoASeparar = new System.Windows.Forms.OpenFileDialog();
            this.lblPaginasExtraidas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionaPdf1
            // 
            this.btnSelecionaPdf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSelecionaPdf1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelecionaPdf1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionaPdf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionaPdf1.Location = new System.Drawing.Point(0, 0);
            this.btnSelecionaPdf1.Name = "btnSelecionaPdf1";
            this.btnSelecionaPdf1.Size = new System.Drawing.Size(1200, 63);
            this.btnSelecionaPdf1.TabIndex = 0;
            this.btnSelecionaPdf1.Text = "Selecionar Pdf";
            this.btnSelecionaPdf1.UseVisualStyleBackColor = false;
            this.btnSelecionaPdf1.Click += new System.EventHandler(this.btnSelecionaPdf1_Click);
            // 
            // lblPdfSelecionado
            // 
            this.lblPdfSelecionado.AutoSize = true;
            this.lblPdfSelecionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPdfSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPdfSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdfSelecionado.Location = new System.Drawing.Point(0, 63);
            this.lblPdfSelecionado.Name = "lblPdfSelecionado";
            this.lblPdfSelecionado.Size = new System.Drawing.Size(265, 25);
            this.lblPdfSelecionado.TabIndex = 1;
            this.lblPdfSelecionado.Text = "1 - Selecione um arquivo .pdf";
            this.lblPdfSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSepararPagina
            // 
            this.btnSepararPagina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSepararPagina.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSepararPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepararPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepararPagina.Location = new System.Drawing.Point(0, 253);
            this.btnSepararPagina.Name = "btnSepararPagina";
            this.btnSepararPagina.Size = new System.Drawing.Size(1175, 63);
            this.btnSepararPagina.TabIndex = 2;
            this.btnSepararPagina.Text = "Extrair páginas";
            this.btnSepararPagina.UseVisualStyleBackColor = false;
            this.btnSepararPagina.Click += new System.EventHandler(this.btnSepararPagina_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblDigitar
            // 
            this.lblDigitar.AutoSize = true;
            this.lblDigitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDigitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitar.Location = new System.Drawing.Point(3, 121);
            this.lblDigitar.Name = "lblDigitar";
            this.lblDigitar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblDigitar.Size = new System.Drawing.Size(599, 45);
            this.lblDigitar.TabIndex = 4;
            this.lblDigitar.Text = "2 - Digite o termo que será buscado e cujas páginas serão extraídas";
            this.lblDigitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selecionarArquivoASeparar
            // 
            this.selecionarArquivoASeparar.FileName = "Selecione Seu Arquivo";
            // 
            // lblPaginasExtraidas
            // 
            this.lblPaginasExtraidas.AutoSize = true;
            this.lblPaginasExtraidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPaginasExtraidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginasExtraidas.Location = new System.Drawing.Point(3, 334);
            this.lblPaginasExtraidas.Name = "lblPaginasExtraidas";
            this.lblPaginasExtraidas.Size = new System.Drawing.Size(395, 25);
            this.lblPaginasExtraidas.TabIndex = 5;
            this.lblPaginasExtraidas.Text = "Termo pesquisado encontrado nas páginas:";
            this.lblPaginasExtraidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeparaPagnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lblPaginasExtraidas);
            this.Controls.Add(this.lblDigitar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSepararPagina);
            this.Controls.Add(this.lblPdfSelecionado);
            this.Controls.Add(this.btnSelecionaPdf1);
            this.Name = "SeparaPagnina";
            this.Size = new System.Drawing.Size(1200, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionaPdf1;
        private System.Windows.Forms.Label lblPdfSelecionado;
        private System.Windows.Forms.Button btnSepararPagina;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDigitar;
        private System.Windows.Forms.OpenFileDialog selecionarArquivoASeparar;
        private System.Windows.Forms.Label lblPaginasExtraidas;
    }
}
