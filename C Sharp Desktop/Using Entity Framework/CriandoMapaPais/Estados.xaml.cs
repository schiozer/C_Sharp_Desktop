using EFLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CriandoMapaPais
{
    /// <summary>
    /// Interaction logic for Estados.xaml
    /// </summary>
    public partial class Estados : Window
    {
        public Estados()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgrEstados.ItemsSource = new EstadoRepository().GetEstados();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            var estado = new Estado()
            {
                uf = txtUF.Text,
                nome = txtNome.Text
            };

            estado = new EstadoRepository().SaveEstado(estado);
            lblId.Content = estado.IdEstado.ToString();
            RefreshDataGrid();
        }
    }
}
