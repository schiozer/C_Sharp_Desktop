using System.Windows.Forms;

namespace ReajusteDeFolhaDePagamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.testes = new System.Windows.Forms.TableLayoutPanel();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblPercentualDoReajuste = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.testes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPercentualDoReajuste);
            this.panel1.Controls.Add(this.lblTotalComReajuste);
            this.panel1.Controls.Add(this.lblTotalSemReajuste);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblArquivo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 105);
            this.panel1.TabIndex = 0;
            // 
            // testes
            // 
            this.testes.ColumnCount = 2;
            this.testes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.67712F));
            this.testes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32288F));
            this.testes.Controls.Add(this.dgvLeitura, 0, 0);
            this.testes.Location = new System.Drawing.Point(2, 112);
            this.testes.Name = "testes";
            this.testes.RowCount = 2;
            this.testes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.34586F));
            this.testes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65414F));
            this.testes.Size = new System.Drawing.Size(638, 243);
            this.testes.TabIndex = 1;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.ReadOnlyChecked = true;
            this.ofdListaFuncionarios.Title = "do arquivo com dados de";
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(3, 3);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(547, 208);
            this.dgvLeitura.TabIndex = 0;
            // 
            // lblArquivo
            // 
            this.lblArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArquivo.Location = new System.Drawing.Point(14, 10);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(525, 30);
            this.lblArquivo.TabIndex = 0;
            this.lblArquivo.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(14, 49);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(141, 30);
            this.lblTotalSemReajuste.TabIndex = 2;
            this.lblTotalSemReajuste.Text = "lblTotalSemReajustelblTotalSemReajuste";
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalComReajuste.Location = new System.Drawing.Point(207, 49);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(141, 30);
            this.lblTotalComReajuste.TabIndex = 3;
            this.lblTotalComReajuste.Text = "lblTotalComReajuste";
            // 
            // lblPercentualDoReajuste
            // 
            this.lblPercentualDoReajuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPercentualDoReajuste.Location = new System.Drawing.Point(398, 49);
            this.lblPercentualDoReajuste.Name = "lblPercentualDoReajuste";
            this.lblPercentualDoReajuste.Size = new System.Drawing.Size(141, 30);
            this.lblPercentualDoReajuste.TabIndex = 4;
            this.lblPercentualDoReajuste.Text = "lblPercentualDoReajuste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 355);
            this.Controls.Add(this.testes);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.testes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel testes;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private DataGridView dgvLeitura;
        private Button button1;
        private Label lblArquivo;
        private Label lblPercentualDoReajuste;
        private Label lblTotalComReajuste;
        private Label lblTotalSemReajuste;
    }
}

