using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumoEnergiaCondominio;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();
        /*A BindingList* é uma classe que implementa a interface IList*/

        public Form1()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dgvLeituras.DataSource = leituraSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSegundoValor.Text);
            int b = Convert.ToInt32(txtPrimeiroValor.Text);
            MessageBox.Show("Pau no seu rabo, arrombado! " + (a % b).ToString("N"), "Aviso aos Pobres", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistraConsumo(txtCasa.Text,
            Convert.ToDouble(txtConsumo.Text));
        }

        private void RegistraConsumo(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura))
            {
                MessageBox.Show("A leitura para esta casa já foi registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                this.leituras.Add(leitura);
                InicializaFormulario();
            }
        }

        private void InicializaFormulario()
        {
            txtCasa.Clear();
            txtConsumo.Clear();
            txtCasa.Focus();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            ProcessarLeituras(dgvLeituras);
        }

        private void ProcessarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgvLeituras.Rows[0].Cells[0];

            this.leituras.Add(new Leitura("Total", 0));

            for (int i = 0; i < 3; i++)
            {
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            double totalConsumo = 0, totalDesconto = 0;

            foreach (var leitura in leituras)
            {
                totalConsumo += leitura.Consumo;
                totalDesconto += leitura.Desconto;
            }

            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString("N");
            lblResultado.Text = "Total consumo sem desconto: " + (totalConsumo - totalDesconto).ToString("N");
        }
    }
}
