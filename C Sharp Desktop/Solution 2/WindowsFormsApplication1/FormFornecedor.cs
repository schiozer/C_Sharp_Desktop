using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller;

        public FormFornecedor(FornecedorController controller)
        {
            InitializeComponent();
            this.controller = controller;

            //
            //string connectionString = ConfigurationManager.AppSettings["CS_ADO_NET"];
            //string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = DBConnection.DB_Connection;//new SqlConnection(connectionString);
            connection.Open();
            controller.setConnection(connection);

        }

        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
               Nome = txtNome.Text, CNPJ = txtCNPJ.Text
            };

            fornecedor = (txtId.Text == string.Empty ? this.controller.Insert(fornecedor) : this.controller.Update(fornecedor));

            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }

        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNome.Enabled = true;
            txtCNPJ.Enabled = true;
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            // txtId.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            // txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            // txtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
            return;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o FORNECEDOR a ser removido no GRID");
            }
            else {
                this.controller.Remove( new Fornecedor() {Id = Int32.Parse(txtId.Text)} );
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource =
                this.controller.GetAll();
                ClearControls();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.RetrieveAllData();
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            Fornecedor fornecedorAtual = this.controller.GetFornecedorById(Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
            txtId.Text = fornecedorAtual.Id.ToString();
            txtNome.Text = fornecedorAtual.Nome;
            txtCNPJ.Text = fornecedorAtual.CNPJ;
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
    }
}
