using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.CRUDSDataSet
{
    public partial class FormFornecedor: Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.FillByNomeComUF(this.dSEstadosECidades.Cidade);
            // TODO: This line of code loads data into the 'dSEstadosECidades.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.dSEstadosECidades.Fornecedor);
        }
    }
}
