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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Candidato> candidatos = new List<Candidato>();

        public MainWindow()
        {
            InitializeComponent();
            GenerateCandidatos();
            PopulateListBox();
        }

        private void GenerateCandidatos()
        {
            candidatos.Add(new Candidato()
            {
                Nome = "Yuri",
                Idade = 25
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Yara",
                Idade = 23
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Gabriel",
                Idade = 20
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Maria Clara",
                Idade = 7
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Vicente Dirceu",
                Idade = 6
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Júlia",
                Idade = 9
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Lívia",
                Idade = 64
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Elio",
                Idade = 74
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Alba",
                Idade = 44
            });
            candidatos.Add(new Candidato()
            {
                Nome = "Angélica",
                Idade = 24
            });
        }

        private void PopulateListBox()
        {
            foreach (var candidato in this.candidatos)
            {
                lbxCandidatos.Items.Add(candidato.Nome);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var qtdeMaiores =
            (from candidato in this.candidatos
             where candidato.Idade >= 18
             orderby candidato.Nome descending
             select candidato).Count();

            var idadesCandidatos = from candidato in this.candidatos
                                    select candidato.Idade;

            var mediaIdade = idadesCandidatos.Average();

            // Início da consulta LINQ
            var maiores = from candidato in this.candidatos
                        where candidato.Idade >= 18
                        orderby candidato.Nome descending
                        select candidato;

            // Término da consulta LINQ
            foreach (var maior in maiores)
            {
                lbxMaiores.Items.Add(maior.Nome);
            }

            var queryMaioresPorMetodos = candidatos.Where(candidato => candidato.Idade >= 18).OrderBy(candidato => candidato.Nome);
            foreach (var maior in queryMaioresPorMetodos)
            {
                lbxMaiores.Items.Add(maior.Nome);
            }
        }
    }
}
