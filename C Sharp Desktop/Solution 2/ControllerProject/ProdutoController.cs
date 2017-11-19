using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class ProdutoController
    {
        private Repository repository = new Repository();
        private SqlConnection connection = null;

        public Produto Insert(Produto produto)
        {

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into PRODUTO (Descricao, PrecoDeCusto, PrecoDeVenda, Estoque) "
                                + "values(@Descricao, @PrecoDeCusto, @PrecoDeVenda, @Estoque) ; "
                                + "select cast(scope_identity() as varchar);";
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoDeCusto", produto.PrecoDeCusto);
            command.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);

            string a = (string)command.ExecuteScalar();
            produto.Id = Int32.Parse(a);
            return this.repository.InsertProduto(produto);
        }

        public void setConnection(SqlConnection conn)
        {
            this.connection = conn;
        }

        public void Remove(Produto produto)
        {
            this.repository.RemoveProduto(produto);
        }

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProdutos();
        }

        public Produto Update(Produto produto)
        {
            return this.repository.UpdateProduto(produto);
        }

        public DataTable RetrieveAllData()
        {
            var adapter = new SqlDataAdapter("select id, Descricao, PrecoDeCusto, PrecoDeVenda, Estoque from PRODUTO", connection);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public Produto GetProdutoById(long id)
        {
            Produto produto = new Produto();

            var command = new SqlCommand("select id, Descricao, PrecoDeCusto, PrecoDeVenda, Estoque from PRODUTO where id = @id", connection);

            command.Parameters.AddWithValue("@id", id);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto.Id = reader.GetInt32(0);
                    produto.Descricao = reader.GetString(1);
                    produto.PrecoDeCusto = reader.GetFloat(2);
                    produto.PrecoDeVenda = reader.GetFloat(3);
                    produto.Estoque = reader.GetInt32(4);
                }
            }

            return produto;
        }

        public void RemoveById(long id)
        {
            var command = new SqlCommand("delete from PRODUTO where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }

        public void UpdateProduto(Produto produto)
        {
            var command = new SqlCommand("update FORNECEDOR set Descricao = @Descricao, "
                                                              + "PrecoDeCusto = @PrecoDeCusto "
                                                              + "PrecoDeVenda = @PrecoDeVenda "
                                                              + "Estoque = @Estoque "
                                                              + "where id = @id", this.connection);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoDeCusto", produto.PrecoDeCusto);
            command.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            command.Parameters.AddWithValue("@id", produto.Id);
            command.ExecuteNonQuery();
        }
    }
}
