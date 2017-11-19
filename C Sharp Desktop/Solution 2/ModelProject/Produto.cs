using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double PrecoDeCusto { get; set; }
        public double PrecoDeVenda { get; set; }
        public double Estoque { get; set; }

        public Produto()
        {

        }

        public Produto(int id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return "Produto: " + this.Id + " - " + this.Descricao;
        }
    }
}
