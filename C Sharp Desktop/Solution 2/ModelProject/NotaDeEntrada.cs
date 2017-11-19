using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class NotaDeEntrada
    {
        public int Id { get; set; }
        public string NumeroNota { get; set; }
        public Fornecedor fornecedor { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ItemNotaDeEntrada> Items { get; set; }

        public NotaDeEntrada()
        {
            this.Items = new List<ItemNotaDeEntrada>();
        }

        public void RegistrarProduto(ItemNotaDeEntrada item)
        {
            if (!this.Items.Contains(item))
                this.Items.Add(item);
        }

        public void RemoverProduto(ItemNotaDeEntrada item)
        {
            this.Items.Remove(item);
        }

        public void RemoverTodosProdutos()
        {
            this.Items.Clear();
        }
    }
}
