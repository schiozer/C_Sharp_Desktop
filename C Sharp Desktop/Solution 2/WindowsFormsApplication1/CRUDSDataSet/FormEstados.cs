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
    public partial class FormEstados : Form
    {
        public FormEstados()
        {
            InitializeComponent();
        }

        private void estadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSEstadosECidades);

        }

        private void FormEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSEstadosECidades.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.dSEstadosECidades.Estado);

        }
    }
}
