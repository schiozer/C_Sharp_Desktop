using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using PersistenceProject;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ControllerProject
{
    public class FornecedorController
    {
        private Repository repository = new Repository();
        private SqlConnection connection = null;

        public Fornecedor Insert(Fornecedor fornecedor)
        {

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into FORNECEDOR(nome, cnpj) values(@nome, @cnpj); " 
                                + "select cast(scope_identity() as varchar);";
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            
            //command.ExecuteNonQuery();
            string a = (string)command.ExecuteScalar();
            fornecedor.Id = Int32.Parse(a);
            return this.repository.InsertFornecedor(fornecedor);
        }

        public void setConnection(SqlConnection conn)
        {
            this.connection = conn;
        }

        public void Remove(Fornecedor fornecedor)
        {
            this.repository.RemoveFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedores();
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
            return this.repository.UpdateFornecedor
            (fornecedor);
        }

        public DataTable RetrieveAllData()
        {
            var adapter = new SqlDataAdapter("select id, cnpj, nome from FORNECEDOR", connection);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public Fornecedor GetFornecedorById(long id)
        {
            Fornecedor fornecedor = new Fornecedor();

            var command = new SqlCommand("select id, cnpj, nome from FORNECEDOR where id = @id", connection);

            command.Parameters.AddWithValue("@id", id);
            //connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fornecedor.Id = reader.GetInt32(0);
                    fornecedor.CNPJ = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
            }

            //connection.Close();
            return fornecedor;
        }

        public void RemoveById(long id)
        {
            var command = new SqlCommand("delete from FORNECEDOR where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }

        public void UpdateForneca(Fornecedor fornecedor)
        {
            var command = new SqlCommand("update FORNECEDOR set cnpj = @cnpj, nome = @nome where id = @id", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@id", fornecedor.Id);
            command.ExecuteNonQuery();
        }
    }
}
