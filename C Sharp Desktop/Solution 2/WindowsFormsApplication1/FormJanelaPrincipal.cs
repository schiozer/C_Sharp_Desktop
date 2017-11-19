using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormJanelaPrincipal : Form
    {

        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        private NotaDeEntradaController notaDeEntradaController = new NotaDeEntradaController();

        public FormJanelaPrincipal()
        {
            InitializeComponent();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        private void notaDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntrada(fornecedorController, produtoController, notaDeEntradaController).ShowDialog();
        }

        private void formDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDataSet().ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CRUDSDataSet.FormEstados().ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CRUDSDataSet.FormCidades().ShowDialog();
        }

        private void fornecedorComDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CRUDSDataSet.FormFornecedor().ShowDialog();
        }
    }
}
