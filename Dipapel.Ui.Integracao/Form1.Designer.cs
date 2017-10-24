namespace Dipapel.Ui.Integracao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnCarregarArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcessarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(506, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnCarregarArquivo
            // 
            this.btnCarregarArquivo.Location = new System.Drawing.Point(524, 10);
            this.btnCarregarArquivo.Name = "btnCarregarArquivo";
            this.btnCarregarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarArquivo.TabIndex = 1;
            this.btnCarregarArquivo.Text = "Abrir Arquivo";
            this.btnCarregarArquivo.UseVisualStyleBackColor = true;
            this.btnCarregarArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV Files | *.csv;";
            // 
            // btnProcessarArquivo
            // 
            this.btnProcessarArquivo.Location = new System.Drawing.Point(607, 10);
            this.btnProcessarArquivo.Name = "btnProcessarArquivo";
            this.btnProcessarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnProcessarArquivo.TabIndex = 2;
            this.btnProcessarArquivo.Text = "Processar Arquivo";
            this.btnProcessarArquivo.UseVisualStyleBackColor = true;
            this.btnProcessarArquivo.Click += new System.EventHandler(this.btnProcessarArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.btnProcessarArquivo);
            this.Controls.Add(this.btnCarregarArquivo);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Dipapel - Integração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnCarregarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcessarArquivo;
    }
}

