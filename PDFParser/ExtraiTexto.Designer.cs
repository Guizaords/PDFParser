
namespace PDFParser
{
    partial class ExtraiTexto
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
            this.btnExtraiTextoPdf = new System.Windows.Forms.Button();
            this.lblDocSelecionado = new System.Windows.Forms.Label();
            this.selecionarArquivo = new System.Windows.Forms.OpenFileDialog();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExtraiTextoPdf
            // 
            this.btnExtraiTextoPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExtraiTextoPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtraiTextoPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraiTextoPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraiTextoPdf.Location = new System.Drawing.Point(0, 0);
            this.btnExtraiTextoPdf.Name = "btnExtraiTextoPdf";
            this.btnExtraiTextoPdf.Size = new System.Drawing.Size(1200, 57);
            this.btnExtraiTextoPdf.TabIndex = 0;
            this.btnExtraiTextoPdf.Text = "Extrair texto de pdf";
            this.btnExtraiTextoPdf.UseVisualStyleBackColor = false;
            this.btnExtraiTextoPdf.Click += new System.EventHandler(this.btnExtraiTextoPdf_Click);
            // 
            // lblDocSelecionado
            // 
            this.lblDocSelecionado.AutoSize = true;
            this.lblDocSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocSelecionado.Location = new System.Drawing.Point(3, 60);
            this.lblDocSelecionado.Name = "lblDocSelecionado";
            this.lblDocSelecionado.Size = new System.Drawing.Size(127, 25);
            this.lblDocSelecionado.TabIndex = 1;
            this.lblDocSelecionado.Text = "Selecionado:";
            // 
            // selecionarArquivo
            // 
            this.selecionarArquivo.FileName = "Selecionar Arquivo";
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(8, 116);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(1157, 363);
            this.rtbTexto.TabIndex = 2;
            this.rtbTexto.Text = "";
            // 
            // ExtraiTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.lblDocSelecionado);
            this.Controls.Add(this.btnExtraiTextoPdf);
            this.Name = "ExtraiTexto";
            this.Size = new System.Drawing.Size(1200, 568);
            this.Load += new System.EventHandler(this.ExtraiTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtraiTextoPdf;
        private System.Windows.Forms.Label lblDocSelecionado;
        private System.Windows.Forms.OpenFileDialog selecionarArquivo;
        private System.Windows.Forms.RichTextBox rtbTexto;
    }
}
