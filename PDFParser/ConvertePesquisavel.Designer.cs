
namespace PDFParser
{
    partial class ConvertePesquisavel
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
            this.btnOcrSelecionarArquivo = new System.Windows.Forms.Button();
            this.lblOcrArquivoSelecionado = new System.Windows.Forms.Label();
            this.btnConverterOcr = new System.Windows.Forms.Button();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.ocrFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOcrSelecionarArquivo
            // 
            this.btnOcrSelecionarArquivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOcrSelecionarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcrSelecionarArquivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcrSelecionarArquivo.Location = new System.Drawing.Point(0, 0);
            this.btnOcrSelecionarArquivo.Name = "btnOcrSelecionarArquivo";
            this.btnOcrSelecionarArquivo.Size = new System.Drawing.Size(634, 82);
            this.btnOcrSelecionarArquivo.TabIndex = 0;
            this.btnOcrSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnOcrSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnOcrSelecionarArquivo.Click += new System.EventHandler(this.btnOcrSelecionarArquivo_Click);
            // 
            // lblOcrArquivoSelecionado
            // 
            this.lblOcrArquivoSelecionado.AutoSize = true;
            this.lblOcrArquivoSelecionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOcrArquivoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcrArquivoSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblOcrArquivoSelecionado.Location = new System.Drawing.Point(0, 82);
            this.lblOcrArquivoSelecionado.Name = "lblOcrArquivoSelecionado";
            this.lblOcrArquivoSelecionado.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblOcrArquivoSelecionado.Size = new System.Drawing.Size(199, 30);
            this.lblOcrArquivoSelecionado.TabIndex = 1;
            this.lblOcrArquivoSelecionado.Text = "Arquivo Selecionado:";
            // 
            // btnConverterOcr
            // 
            this.btnConverterOcr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverterOcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverterOcr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConverterOcr.Location = new System.Drawing.Point(0, 112);
            this.btnConverterOcr.Name = "btnConverterOcr";
            this.btnConverterOcr.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnConverterOcr.Size = new System.Drawing.Size(634, 82);
            this.btnConverterOcr.TabIndex = 2;
            this.btnConverterOcr.Text = "Converter em PDF Pesquisável";
            this.btnConverterOcr.UseVisualStyleBackColor = true;
            this.btnConverterOcr.Click += new System.EventHandler(this.btnConverterOcr_Click);
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertido.ForeColor = System.Drawing.Color.White;
            this.lblConvertido.Location = new System.Drawing.Point(0, 194);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblConvertido.Size = new System.Drawing.Size(41, 30);
            this.lblConvertido.TabIndex = 3;
            this.lblConvertido.Text = "(...)";
            this.lblConvertido.Click += new System.EventHandler(this.lblConvertido_Click);
            // 
            // ocrFileDialog
            // 
            this.ocrFileDialog.FileName = "Selecionar Arquivo";
            this.ocrFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ocrFileDialog_FileOk);
            // 
            // ConvertePesquisavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lblConvertido);
            this.Controls.Add(this.btnConverterOcr);
            this.Controls.Add(this.lblOcrArquivoSelecionado);
            this.Controls.Add(this.btnOcrSelecionarArquivo);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ConvertePesquisavel";
            this.Size = new System.Drawing.Size(634, 568);
            this.Load += new System.EventHandler(this.ConvertePesquisavel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcrSelecionarArquivo;
        private System.Windows.Forms.Label lblOcrArquivoSelecionado;
        private System.Windows.Forms.Button btnConverterOcr;
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.OpenFileDialog ocrFileDialog;
    }
}
