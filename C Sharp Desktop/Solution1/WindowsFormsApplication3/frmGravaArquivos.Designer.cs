namespace PreparacaoDeDadosParaGravacao
{
    partial class frmGravaArquivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtFuncs = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Funcionários";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(301, 20);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(245, 31);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvFuncionarios.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvFuncionarios.Location = new System.Drawing.Point(3, 79);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowTemplate.Height = 24;
            this.dgvFuncionarios.Size = new System.Drawing.Size(645, 265);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // txtFuncs
            // 
            this.txtFuncs.Location = new System.Drawing.Point(168, 27);
            this.txtFuncs.Name = "txtFuncs";
            this.txtFuncs.Size = new System.Drawing.Size(105, 22);
            this.txtFuncs.TabIndex = 4;
            // 
            // btnGerar
            // 
            this.btnGerar.Enabled = false;
            this.btnGerar.Location = new System.Drawing.Point(17, 367);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(242, 38);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar Arquivo";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(374, 367);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(236, 37);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // frmGravaArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 418);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFuncs);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label1);
            this.Name = "frmGravaArquivos";
            this.Text = "Grava Arquivos";
            this.Load += new System.EventHandler(this.frmGravaArquivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtFuncs;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

