using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    /* Uma classe sealed não pode ser herdada*/
    public sealed class DBConnection
    {
        /*volatile na definição de um campo informa que este pode ser modificado por diversas partes da aplicação ao mesmo tempo*/
        private static volatile SqlConnection instance;

        /*Pelo fato de a classe implementar o padrão Singleton, ela não pode ser instanciada. Desta maneira, seu construtor padrão precisa
          ser explicitamente implementado e ser privado à classe, como pode ser verificado na implementação*/
        private DBConnection() { }

        public static SqlConnection DB_Connection
        {
            get
            {
                if (instance == null)
                {
                    //instance = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString);
                    instance = new SqlConnection(ConfigurationManager.ConnectionStrings["TestesDB"].ConnectionString);
                }
                return instance;
            }
        }
    }
}
