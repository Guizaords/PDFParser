
namespace PDFParser
{
    partial class PdfParser
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelLateral = new System.Windows.Forms.Panel();
            this.btnConverterHtml = new System.Windows.Forms.Button();
            this.btnConverteOcr = new System.Windows.Forms.Button();
            this.btnSepararPdf = new System.Windows.Forms.Button();
            this.btnExtrairTexto = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.painelSuperior = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.htmlParaPdf1 = new PDFParser.HtmlParaPdf();
            this.principal1 = new PDFParser.Principal();
            this.convertePesquisavel1 = new PDFParser.ConvertePesquisavel();
            this.separaPagnina1 = new PDFParser.SeparaPagnina();
            this.extraiTexto1 = new PDFParser.ExtraiTexto();
            this.painelLateral.SuspendLayout();
            this.painelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelLateral
            // 
            this.painelLateral.BackColor = System.Drawing.SystemColors.HotTrack;
            this.painelLateral.Controls.Add(this.btnConverterHtml);
            this.painelLateral.Controls.Add(this.btnConverteOcr);
            this.painelLateral.Controls.Add(this.btnSepararPdf);
            this.painelLateral.Controls.Add(this.btnExtrairTexto);
            this.painelLateral.Controls.Add(this.btnHome);
            this.painelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(328, 606);
            this.painelLateral.TabIndex = 0;
            // 
            // btnConverterHtml
            // 
            this.btnConverterHtml.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverterHtml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConverterHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverterHtml.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConverterHtml.Location = new System.Drawing.Point(0, 488);
            this.btnConverterHtml.Name = "btnConverterHtml";
            this.btnConverterHtml.Size = new System.Drawing.Size(328, 122);
            this.btnConverterHtml.TabIndex = 4;
            this.btnConverterHtml.Text = "Converter Html para .pdf";
            this.btnConverterHtml.UseVisualStyleBackColor = true;
            this.btnConverterHtml.Click += new System.EventHandler(this.btnConverterHtml_Click);
            // 
            // btnConverteOcr
            // 
            this.btnConverteOcr.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnConverteOcr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverteOcr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConverteOcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverteOcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverteOcr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConverteOcr.Location = new System.Drawing.Point(0, 366);
            this.btnConverteOcr.Name = "btnConverteOcr";
            this.btnConverteOcr.Size = new System.Drawing.Size(328, 122);
            this.btnConverteOcr.TabIndex = 3;
            this.btnConverteOcr.Text = "Converter para .pdf pesquisável";
            this.btnConverteOcr.UseVisualStyleBackColor = false;
            this.btnConverteOcr.Click += new System.EventHandler(this.btnConverteOcr_Click);
            // 
            // btnSepararPdf
            // 
            this.btnSepararPdf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSepararPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSepararPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSepararPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepararPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepararPdf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSepararPdf.Location = new System.Drawing.Point(0, 244);
            this.btnSepararPdf.Name = "btnSepararPdf";
            this.btnSepararPdf.Size = new System.Drawing.Size(328, 122);
            this.btnSepararPdf.TabIndex = 2;
            this.btnSepararPdf.Text = "Separar páginas de um .pdf com base em uma pesquisa";
            this.btnSepararPdf.UseVisualStyleBackColor = false;
            this.btnSepararPdf.Click += new System.EventHandler(this.btnSepararPdf_Click);
            // 
            // btnExtrairTexto
            // 
            this.btnExtrairTexto.BackColor = System.Drawing.Color.Gray;
            this.btnExtrairTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtrairTexto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnExtrairTexto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExtrairTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrairTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrairTexto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExtrairTexto.Location = new System.Drawing.Point(0, 122);
            this.btnExtrairTexto.Name = "btnExtrairTexto";
            this.btnExtrairTexto.Size = new System.Drawing.Size(328, 122);
            this.btnExtrairTexto.TabIndex = 1;
            this.btnExtrairTexto.Text = "Extrair Texto de um .pdf";
            this.btnExtrairTexto.UseVisualStyleBackColor = false;
            this.btnExtrairTexto.Click += new System.EventHandler(this.btnExtrairTexto_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(328, 122);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Principal";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // painelSuperior
            // 
            this.painelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.painelSuperior.Controls.Add(this.btnSair);
            this.painelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSuperior.Location = new System.Drawing.Point(328, 0);
            this.painelSuperior.Name = "painelSuperior";
            this.painelSuperior.Size = new System.Drawing.Size(1392, 43);
            this.painelSuperior.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(1355, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 43);
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Funcionalidades disponíveis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // htmlParaPdf1
            // 
            this.htmlParaPdf1.AutoScroll = true;
            this.htmlParaPdf1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlParaPdf1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlParaPdf1.Location = new System.Drawing.Point(328, 43);
            this.htmlParaPdf1.Name = "htmlParaPdf1";
            this.htmlParaPdf1.Size = new System.Drawing.Size(1392, 563);
            this.htmlParaPdf1.TabIndex = 7;
            // 
            // principal1
            // 
            this.principal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal1.Location = new System.Drawing.Point(328, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(1392, 606);
            this.principal1.TabIndex = 2;
            // 
            // convertePesquisavel1
            // 
            this.convertePesquisavel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertePesquisavel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertePesquisavel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.convertePesquisavel1.Location = new System.Drawing.Point(0, 0);
            this.convertePesquisavel1.Name = "convertePesquisavel1";
            this.convertePesquisavel1.Size = new System.Drawing.Size(1720, 606);
            this.convertePesquisavel1.TabIndex = 5;
            // 
            // separaPagnina1
            // 
            this.separaPagnina1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separaPagnina1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.separaPagnina1.Location = new System.Drawing.Point(0, 0);
            this.separaPagnina1.Name = "separaPagnina1";
            this.separaPagnina1.Size = new System.Drawing.Size(1720, 606);
            this.separaPagnina1.TabIndex = 4;
            // 
            // extraiTexto1
            // 
            this.extraiTexto1.AutoScroll = true;
            this.extraiTexto1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.extraiTexto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extraiTexto1.Location = new System.Drawing.Point(0, 0);
            this.extraiTexto1.Name = "extraiTexto1";
            this.extraiTexto1.Size = new System.Drawing.Size(1720, 606);
            this.extraiTexto1.TabIndex = 3;
            // 
            // PdfParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1720, 606);
            this.Controls.Add(this.htmlParaPdf1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.painelSuperior);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.painelLateral);
            this.Controls.Add(this.convertePesquisavel1);
            this.Controls.Add(this.separaPagnina1);
            this.Controls.Add(this.extraiTexto1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PdfParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfParser";
            this.painelLateral.ResumeLayout(false);
            this.painelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelLateral;
        private System.Windows.Forms.Panel painelSuperior;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConverterHtml;
        private System.Windows.Forms.Button btnConverteOcr;
        private System.Windows.Forms.Button btnSepararPdf;
        private System.Windows.Forms.Button btnExtrairTexto;
        private System.Windows.Forms.Button btnSair;
        private Principal principal1;
        private ExtraiTexto extraiTexto1;
        private SeparaPagnina separaPagnina1;
        private ConvertePesquisavel convertePesquisavel1;
        private System.Windows.Forms.Label label1;
        private HtmlParaPdf htmlParaPdf1;
    }
}

