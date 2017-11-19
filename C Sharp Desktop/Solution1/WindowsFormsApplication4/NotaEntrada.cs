using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    class NotaEntrada
    {
        public string NumeroNota { get; set; }
        public string NomeFornecedor { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }

        public NotaEntrada()
        {
            this.Produtos = new List<ProdutoNotaEntrada>();
        }

        public void RegistrarProduto(ProdutoNotaEntrada produto)
        {
            if (!this.Produtos.Contains(produto))
                this.Produtos.Add(produto);
        }

        public void RemoverProduto(ProdutoNotaEntrada produto)
        {
            this.Produtos.Remove(produto);
        }

        public void RemoverTodosProdutos()
        {
            this.Produtos.Clear();
        }
    }
}
