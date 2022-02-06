
namespace PDFParser
{
    partial class HtmlParaPdf
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
            this.HtmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionarHtml = new System.Windows.Forms.Button();
            this.lblHtmlSelecionado = new System.Windows.Forms.Label();
            this.lblDocumentoSelecionado2 = new System.Windows.Forms.Label();
            this.converterHtml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HtmlFileDialog
            // 
            this.HtmlFileDialog.FileName = "Selecione Seus Arquivos Html";
            this.HtmlFileDialog.Filter = "\"Arquivos Html\"|*html";
            this.HtmlFileDialog.Multiselect = true;
            // 
            // btnSelecionarHtml
            // 
            this.btnSelecionarHtml.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelecionarHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarHtml.Location = new System.Drawing.Point(0, 0);
            this.btnSelecionarHtml.Name = "btnSelecionarHtml";
            this.btnSelecionarHtml.Size = new System.Drawing.Size(1200, 82);
            this.btnSelecionarHtml.TabIndex = 0;
            this.btnSelecionarHtml.Text = "SELECIONAR ARQUIVO(S)";
            this.btnSelecionarHtml.UseVisualStyleBackColor = true;
            this.btnSelecionarHtml.Click += new System.EventHandler(this.btnSelecionarHtml_Click);
            // 
            // lblHtmlSelecionado
            // 
            this.lblHtmlSelecionado.AutoSize = true;
            this.lblHtmlSelecionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHtmlSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHtmlSelecionado.Location = new System.Drawing.Point(0, 82);
            this.lblHtmlSelecionado.Name = "lblHtmlSelecionado";
            this.lblHtmlSelecionado.Size = new System.Drawing.Size(280, 25);
            this.lblHtmlSelecionado.TabIndex = 1;
            this.lblHtmlSelecionado.Text = "Documento(s) Selecionado(s):";
            // 
            // lblDocumentoSelecionado2
            // 
            this.lblDocumentoSelecionado2.AutoSize = true;
            this.lblDocumentoSelecionado2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDocumentoSelecionado2.Location = new System.Drawing.Point(0, 107);
            this.lblDocumentoSelecionado2.Name = "lblDocumentoSelecionado2";
            this.lblDocumentoSelecionado2.Size = new System.Drawing.Size(30, 17);
            this.lblDocumentoSelecionado2.TabIndex = 2;
            this.lblDocumentoSelecionado2.Text = "(...)";
            // 
            // converterHtml
            // 
            this.converterHtml.Dock = System.Windows.Forms.DockStyle.Top;
            this.converterHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterHtml.Location = new System.Drawing.Point(0, 124);
            this.converterHtml.Name = "converterHtml";
            this.converterHtml.Size = new System.Drawing.Size(1200, 82);
            this.converterHtml.TabIndex = 3;
            this.converterHtml.Text = "CONVERTER HTML PARA PDF";
            this.converterHtml.UseVisualStyleBackColor = true;
            this.converterHtml.Click += new System.EventHandler(this.converterHtml_Click);
            // 
            // HtmlParaPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.converterHtml);
            this.Controls.Add(this.lblDocumentoSelecionado2);
            this.Controls.Add(this.lblHtmlSelecionado);
            this.Controls.Add(this.btnSelecionarHtml);
            this.Name = "HtmlParaPdf";
            this.Size = new System.Drawing.Size(1200, 456);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog HtmlFileDialog;
        private System.Windows.Forms.Button btnSelecionarHtml;
        private System.Windows.Forms.Label lblHtmlSelecionado;
        private System.Windows.Forms.Label lblDocumentoSelecionado2;
        private System.Windows.Forms.Button converterHtml;
    }
}
