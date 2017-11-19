using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class NotaDeEntradaController
    {
        private SqlConnection connection = null;
        public Repository repository { get; }

        public NotaDeEntradaController()
        {
            this.repository = new Repository();
        }

        public void setConnection(SqlConnection conn)
        {
            this.connection = conn;
        }

        public NotaDeEntrada Insert(NotaDeEntrada notaDeEntrada)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into NotaDeEntrada(IdFornecedor, Numero, DataEmissao, DataEntrada) "
                                + "output INSERTED.ID values(@IdFornecedor, @Numero, @DataEmissao, @DataEntrada)";

            command.Parameters.AddWithValue("@IdFornecedor", notaDeEntrada.fornecedor.Id);
            command.Parameters.AddWithValue("@Numero", notaDeEntrada.NumeroNota);
            command.Parameters.AddWithValue("@DataEmissao", notaDeEntrada.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", notaDeEntrada.DataEntrada);

            //command.ExecuteNonQuery();
            notaDeEntrada.Id = (int)command.ExecuteScalar();

            foreach (ItemNotaDeEntrada item in notaDeEntrada.Items)
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "insert into ItemNotaDeEntrada(IdNotaDeEntrada, IdProduto, PrecoCustoCompra, Qtde) "
                                + "values(@IdNotaDeEntrada, @IdProduto, @PrecoCustoCompra, @Qtde)";

                cmd.Parameters.AddWithValue("@IdNotaDeEntrada", notaDeEntrada.Id);
                cmd.Parameters.AddWithValue("@IdProduto", item.Produto.Id);
                cmd.Parameters.AddWithValue("@PrecoCustoCompra", item.PrecoCustoCompra);
                cmd.Parameters.AddWithValue("@Qtde", item.QuantidadeComprada);

                cmd.ExecuteNonQuery();
            }

            return this.repository.InsertNotaDeEntrada(notaDeEntrada);
        }

        public NotaDeEntrada Update(NotaDeEntrada notaDeEntrada)
        {
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "update NotaDeEntrada set "
                                + "IdFornecedor = @IdFornecedor, "
                                + "Numero = @Numero, "
                                + "DataEmissao = @DataEmissao, "
                                + "DataEntrada = @DataEntrada "
                                + "where Id = @Id ";

            command.Parameters.AddWithValue("@IdFornecedore", notaDeEntrada.fornecedor.Id);
            command.Parameters.AddWithValue("@Numero", notaDeEntrada.NumeroNota);
            command.Parameters.AddWithValue("@DataEmissao", notaDeEntrada.DataEmissao);
            command.Parameters.AddWithValue("@DataEntrada", notaDeEntrada.DataEntrada);
            command.Parameters.AddWithValue("@Id", notaDeEntrada.Id);

            command.ExecuteNonQuery();

            DeleteAllItemsFromNotaEntrada(notaDeEntrada);
            InsertItemsNotaDeEntrada(notaDeEntrada);

            return this.repository.InsertNotaDeEntrada(notaDeEntrada);
        }

        private void DeleteAllItemsFromNotaEntrada(NotaDeEntrada notaDeEntrada)
        {
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "delete from ProdutoNotaDeEntrada "
                                + "where IdNotaDeEntrada = @IdNotaDeEntrada ";

            command.Parameters.AddWithValue("@IdNotaDeEntrada", notaDeEntrada.Id);

            command.ExecuteNonQuery();

            return;
        }

        private void InsertItemsNotaDeEntrada(NotaDeEntrada notaDeEntrada)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into ProdutoNotaDeEntrada(IdNotaEntrada, IdProduto, PrecoCustoCompra, Qtde) "
                                + "values(@IdNotaEntrada, @IdProduto, @PrecoCustoCompra, @Qtde)";

            foreach (ItemNotaDeEntrada item in notaDeEntrada.Items)
            {
                command.Parameters.AddWithValue("@IdNotaEntrada", notaDeEntrada.Id);
                command.Parameters.AddWithValue("@IdProduto", item.Produto.Id);
                command.Parameters.AddWithValue("@PrecoCustoCompra", item.PrecoCustoCompra);
                command.Parameters.AddWithValue("@Qtde", item.QuantidadeComprada);
            }

            command.ExecuteNonQuery();

            return;
        }
    }
}
