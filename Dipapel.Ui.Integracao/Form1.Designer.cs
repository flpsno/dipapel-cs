namespace Dipapel.Ui.Integracao
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.dtgvPedidos = new System.Windows.Forms.DataGridView();
            this.pgbPedidos = new System.Windows.Forms.ProgressBar();
            this.lblNovos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEditados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(478, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnCarregarArquivo
            // 
            this.btnCarregarArquivo.Location = new System.Drawing.Point(496, 10);
            this.btnCarregarArquivo.Name = "btnCarregarArquivo";
            this.btnCarregarArquivo.Size = new System.Drawing.Size(103, 23);
            this.btnCarregarArquivo.TabIndex = 1;
            this.btnCarregarArquivo.Text = "Carregar Arquivo";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total de Pedidos:";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidos.Location = new System.Drawing.Point(105, 40);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(35, 25);
            this.lblTotalPedidos.TabIndex = 4;
            this.lblTotalPedidos.Text = "10";
            // 
            // dtgvPedidos
            // 
            this.dtgvPedidos.AllowUserToAddRows = false;
            this.dtgvPedidos.AllowUserToDeleteRows = false;
            this.dtgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPedidos.Location = new System.Drawing.Point(12, 108);
            this.dtgvPedidos.Name = "dtgvPedidos";
            this.dtgvPedidos.ReadOnly = true;
            this.dtgvPedidos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtgvPedidos.ShowEditingIcon = false;
            this.dtgvPedidos.Size = new System.Drawing.Size(670, 307);
            this.dtgvPedidos.TabIndex = 5;
            // 
            // pgbPedidos
            // 
            this.pgbPedidos.Location = new System.Drawing.Point(12, 68);
            this.pgbPedidos.Name = "pgbPedidos";
            this.pgbPedidos.Size = new System.Drawing.Size(670, 23);
            this.pgbPedidos.Step = 1;
            this.pgbPedidos.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbPedidos.TabIndex = 6;
            this.pgbPedidos.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblNovos
            // 
            this.lblNovos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovos.Location = new System.Drawing.Point(280, 40);
            this.lblNovos.Name = "lblNovos";
            this.lblNovos.Size = new System.Drawing.Size(35, 25);
            this.lblNovos.TabIndex = 8;
            this.lblNovos.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Novos:";
            // 
            // lblEditados
            // 
            this.lblEditados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditados.Location = new System.Drawing.Point(496, 40);
            this.lblEditados.Name = "lblEditados";
            this.lblEditados.Size = new System.Drawing.Size(35, 25);
            this.lblEditados.TabIndex = 10;
            this.lblEditados.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editados:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.lblEditados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNovos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pgbPedidos);
            this.Controls.Add(this.dtgvPedidos);
            this.Controls.Add(this.lblTotalPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcessarArquivo);
            this.Controls.Add(this.btnCarregarArquivo);
            this.Controls.Add(this.txtFilePath);
            this.Name = "frmPrincipal";
            this.Text = "Dipapel - Integração";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnCarregarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcessarArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.DataGridView dtgvPedidos;
        private System.Windows.Forms.ProgressBar pgbPedidos;
        private System.Windows.Forms.Label lblNovos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEditados;
        private System.Windows.Forms.Label label5;
    }
}

