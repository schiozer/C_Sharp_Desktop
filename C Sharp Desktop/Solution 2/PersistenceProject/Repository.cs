using System.Collections.Generic;
using ModelProject;

namespace PersistenceProject
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<ItemNotaDeEntrada> itemsNotaDeEntrada = new List<ItemNotaDeEntrada>();
        private IList<NotaDeEntrada> notasDeENtrada = new List<NotaDeEntrada>();

        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }

        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }

        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.fornecedores;
        }

        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }

        public Produto InsertProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }

        public void RemoveProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }

        public IList<Produto> GetAllProdutos()
        {
            return this.produtos;
        }

        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }

        public NotaDeEntrada InsertNotaDeEntrada(NotaDeEntrada notaDeEntrada)
        {
            this.notasDeENtrada.Add(notaDeEntrada);
            return notaDeEntrada;
        }

        public ItemNotaDeEntrada InsertItemNotaDeEntrada(ItemNotaDeEntrada item)
        {
            this.itemsNotaDeEntrada.Add(item);
            return item;
        }

        public void RemoveItemNotaDeEntrada(ItemNotaDeEntrada item)
        {
            this.itemsNotaDeEntrada.Remove(item);
        }

        public IList<ItemNotaDeEntrada> GetAllItemsNotaDeEntrada()
        {
            return this.itemsNotaDeEntrada;
        }

        public ItemNotaDeEntrada UpdateItemNotaDeEntrada(ItemNotaDeEntrada item)
        {
            this.itemsNotaDeEntrada[this.itemsNotaDeEntrada.IndexOf(item)] = item;
            return item;
        }
    }
}
