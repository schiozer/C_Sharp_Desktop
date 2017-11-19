namespace WindowsFormsApplication1
{
    partial class FormDataSet
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
            this.tabDataset = new System.Windows.Forms.TabControl();
            this.tabXML = new System.Windows.Forms.TabPage();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.tabDadosControles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.btnControlesVisuais = new System.Windows.Forms.Button();
            this.btnVisualizarXML = new System.Windows.Forms.Button();
            this.btnInserirDados = new System.Windows.Forms.Button();
            this.btnCriarDataset = new System.Windows.Forms.Button();
            this.tabDataset.SuspendLayout();
            this.tabXML.SuspendLayout();
            this.tabDadosControles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataset
            // 
            this.tabDataset.Controls.Add(this.tabXML);
            this.tabDataset.Controls.Add(this.tabDadosControles);
            this.tabDataset.Location = new System.Drawing.Point(11, 69);
            this.tabDataset.Name = "tabDataset";
            this.tabDataset.SelectedIndex = 0;
            this.tabDataset.Size = new System.Drawing.Size(855, 410);
            this.tabDataset.TabIndex = 9;
            // 
            // tabXML
            // 
            this.tabXML.Controls.Add(this.txtXML);
            this.tabXML.Location = new System.Drawing.Point(4, 25);
            this.tabXML.Name = "tabXML";
            this.tabXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabXML.Size = new System.Drawing.Size(847, 381);
            this.tabXML.TabIndex = 0;
            this.tabXML.Text = "Dados em XML";
            this.tabXML.UseVisualStyleBackColor = true;
            // 
            // txtXML
            // 
            this.txtXML.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXML.Location = new System.Drawing.Point(5, 8);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(841, 372);
            this.txtXML.TabIndex = 0;
            // 
            // tabDadosControles
            // 
            this.tabDadosControles.Controls.Add(this.tableLayoutPanel1);
            this.tabDadosControles.Location = new System.Drawing.Point(4, 25);
            this.tabDadosControles.Name = "tabDadosControles";
            this.tabDadosControles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosControles.Size = new System.Drawing.Size(847, 381);
            this.tabDadosControles.TabIndex = 1;
            this.tabDadosControles.Text = "Dados em Controles";
            this.tabDadosControles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.637231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.36277F));
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbEstado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCidades, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.055555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.94444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Location = new System.Drawing.Point(3, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 28);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(66, 3);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(514, 24);
            this.cmbEstado.TabIndex = 1;
            // 
            // dgvCidades
            // 
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCidades, 2);
            this.dgvCidades.Location = new System.Drawing.Point(3, 31);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.RowTemplate.Height = 24;
            this.dgvCidades.Size = new System.Drawing.Size(832, 326);
            this.dgvCidades.TabIndex = 2;
            // 
            // btnControlesVisuais
            // 
            this.btnControlesVisuais.Location = new System.Drawing.Point(658, 5);
            this.btnControlesVisuais.Name = "btnControlesVisuais";
            this.btnControlesVisuais.Size = new System.Drawing.Size(153, 42);
            this.btnControlesVisuais.TabIndex = 8;
            this.btnControlesVisuais.Text = "Controles Visuais";
            this.btnControlesVisuais.UseVisualStyleBackColor = true;
            this.btnControlesVisuais.Click += new System.EventHandler(this.btnControlesVisuais_Click);
            // 
            // btnVisualizarXML
            // 
            this.btnVisualizarXML.Location = new System.Drawing.Point(450, 5);
            this.btnVisualizarXML.Name = "btnVisualizarXML";
            this.btnVisualizarXML.Size = new System.Drawing.Size(153, 42);
            this.btnVisualizarXML.TabIndex = 7;
            this.btnVisualizarXML.Text = "Visualizar XML";
            this.btnVisualizarXML.UseVisualStyleBackColor = true;
            this.btnVisualizarXML.Click += new System.EventHandler(this.btnVisualizarXML_Click);
            // 
            // btnInserirDados
            // 
            this.btnInserirDados.Location = new System.Drawing.Point(248, 5);
            this.btnInserirDados.Name = "btnInserirDados";
            this.btnInserirDados.Size = new System.Drawing.Size(153, 42);
            this.btnInserirDados.TabIndex = 6;
            this.btnInserirDados.Text = "Inserir Dados";
            this.btnInserirDados.UseVisualStyleBackColor = true;
            this.btnInserirDados.Click += new System.EventHandler(this.btnInserirDados_Click);
            // 
            // btnCriarDataset
            // 
            this.btnCriarDataset.Location = new System.Drawing.Point(28, 5);
            this.btnCriarDataset.Name = "btnCriarDataset";
            this.btnCriarDataset.Size = new System.Drawing.Size(153, 42);
            this.btnCriarDataset.TabIndex = 5;
            this.btnCriarDataset.Text = "Criar DataSet";
            this.btnCriarDataset.UseVisualStyleBackColor = true;
            this.btnCriarDataset.Click += new System.EventHandler(this.btnCriarDataset_Click);
            // 
            // FormDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 484);
            this.Controls.Add(this.tabDataset);
            this.Controls.Add(this.btnControlesVisuais);
            this.Controls.Add(this.btnVisualizarXML);
            this.Controls.Add(this.btnInserirDados);
            this.Controls.Add(this.btnCriarDataset);
            this.Name = "FormDataSet";
            this.Text = "FormDataSet";
            this.tabDataset.ResumeLayout(false);
            this.tabXML.ResumeLayout(false);
            this.tabXML.PerformLayout();
            this.tabDadosControles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDataset;
        private System.Windows.Forms.TabPage tabXML;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TabPage tabDadosControles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.Button btnControlesVisuais;
        private System.Windows.Forms.Button btnVisualizarXML;
        private System.Windows.Forms.Button btnInserirDados;
        private System.Windows.Forms.Button btnCriarDataset;
    }
}