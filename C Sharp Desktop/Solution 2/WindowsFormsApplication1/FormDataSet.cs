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
    public partial class FormDataSet : Form
    {
        private DataSet dsEstadosCidades;

        public FormDataSet()
        {
            InitializeComponent();
        }

        private void btnCriarDataset_Click(object sender, EventArgs e)
        {
            dsEstadosCidades = InitializeDataSet();
            MessageBox.Show("DataSet inicializado com sucesso");
        }

        private DataSet InitializeDataSet()
        {
            DataTable dtEstados = new DataTable("Estados");
            dtEstados.Columns.Add("id");
            dtEstados.Columns.Add("uf");
            dtEstados.Columns.Add("nome");

            DataTable dtCidades = new DataTable("Cidades");
            dtCidades.Columns.Add("id");
            dtCidades.Columns.Add("idestado");
            dtCidades.Columns.Add("nome");

            DataSet dsEstadosCidades = new DataSet("EstadosCidades");
            dsEstadosCidades.Tables.Add(dtEstados);
            dsEstadosCidades.Tables.Add(dtCidades);

            DataRelation drCidadeEstado = new DataRelation("CidadesEstados",
            dtEstados.Columns["id"],
            dtCidades.Columns["idestado"]);

            dsEstadosCidades.Relations.Add(drCidadeEstado);

            return dsEstadosCidades;
        }

        private void btnInserirDados_Click(object sender, EventArgs e)
        {
            DataTable dtEstados = dsEstadosCidades.Tables["Estados"];
            dtEstados.Rows.Add(1, "PR", "Paraná");
            dtEstados.Rows.Add(2, "SP", "São Paulo");
            dtEstados.Rows.Add(3, "SC", "Santa Catarina");

            DataTable dtCidades = dsEstadosCidades.Tables["Cidades"];
            dtCidades.Rows.Add(1, 1, "Foz do Iguaçu");
            dtCidades.Rows.Add(2, 1, "Medianeira");
            dtCidades.Rows.Add(3, 1, "Curitiba");
            dtCidades.Rows.Add(4, 2, "São Paulo");
            dtCidades.Rows.Add(5, 2, "Ilha Solteira");
            dtCidades.Rows.Add(6, 3, "Florianópolis");

            MessageBox.Show("Dados inseridos com sucesso.");
        }

        private void btnVisualizarXML_Click(object sender, EventArgs e)
        {
            tabDataset.SelectedTab = tabXML;
            txtXML.Text = dsEstadosCidades.GetXml();
        }

        private void btnControlesVisuais_Click(object sender, EventArgs e)
        {
            BindingSource bsMaster = new BindingSource();

            BindingSource bsDetails = new BindingSource();

            bsMaster.DataSource = dsEstadosCidades;
            bsMaster.DataMember = "Estados";

            bsDetails.DataSource = bsMaster;
            bsDetails.DataMember = "CidadesEstados";

            tabDataset.SelectedTab = tabDadosControles;

            cmbEstado.DataSource = bsMaster;
            cmbEstado.DisplayMember = "nome";
            cmbEstado.ValueMember = "id";

            dgvCidades.DataSource = bsDetails;
        }
    }
}

