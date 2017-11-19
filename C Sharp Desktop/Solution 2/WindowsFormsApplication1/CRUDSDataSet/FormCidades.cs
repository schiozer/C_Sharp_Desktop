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
    public partial class FormCidades : Form
    {
        public FormCidades()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.dSEstadosECidades.Estado);
            // TODO: This line of code loads data into the 'dSEstadosECidades.Cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.dSEstadosECidades.Cidade);

        }
    }
}
