using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormNotaEntrada : Form
    {
        private FornecedorController    controllerFornecedor;
        private ProdutoController       controllerProduto;
        private NotaDeEntradaController controllerNotaDeEntrada;


        public FormNotaEntrada(FornecedorController controllerFornecedor, ProdutoController controllerProduto, NotaDeEntradaController controllerNotaDeEntrada)
        {
            InitializeComponent();
            this.controllerFornecedor = controllerFornecedor;
            this.controllerProduto = controllerProduto;
            this.controllerNotaDeEntrada = controllerNotaDeEntrada;

            SqlConnection connection = DBConnection.DB_Connection;//new SqlConnection(connectionString);
            connection.Open();
            this.controllerFornecedor.setConnection(connection);
            this.controllerProduto.setConnection(connection);
            this.controllerNotaDeEntrada.setConnection(connection);
        }

        public FormNotaEntrada()
        {
            InitializeComponent();
        }

        private void FormNotaEntrada_Load(object sender, EventArgs e)
        {
            // Preenche Combo de Fornecedores
            cmbFornecedores.DataSource = null;
            cmbFornecedores.DisplayMember = "nome";
            cmbFornecedores.ValueMember = "id";
            cmbFornecedores.DataSource = this.controllerFornecedor.RetrieveAllData();

            // Preenche Combo de Produtos
            cmbProdutos.DataSource = null;
            cmbProdutos.DisplayMember = "Descricao";
            cmbProdutos.ValueMember = "id";
            cmbProdutos.DataSource = this.controllerProduto.RetrieveAllData();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ItemNotaDeEntrada item = new ItemNotaDeEntrada();


            item.PrecoCustoCompra = Double.Parse(txtPrecoCusto.Text);
            item.QuantidadeComprada = Int32.Parse(txtQtde.Text);
            int a = (int)cmbProdutos.SelectedValue;
            Produto prod = new Produto(a);
            prod.Descricao = cmbProdutos.SelectedText;
            item.Produto = prod;
            this.controllerNotaDeEntrada.repository.InsertItemNotaDeEntrada(item);
            dgvItemsNota.DataSource = null;
            dgvItemsNota.DataSource = this.controllerNotaDeEntrada.repository.GetAllItemsNotaDeEntrada();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            NotaDeEntrada nota = new NotaDeEntrada();
            nota.NumeroNota = txtNumeroNota.Text;
            nota.DataEmissao = DateTime.Parse(dtpDataEmissao.Text);
            nota.DataEntrada = DateTime.Parse(dtpDataEntrada.Text);
            nota.fornecedor = new Fornecedor((int)cmbFornecedores.SelectedValue);
            nota.Items = this.controllerNotaDeEntrada.repository.GetAllItemsNotaDeEntrada();
            this.controllerNotaDeEntrada.Insert(nota);
        }
    }
}
