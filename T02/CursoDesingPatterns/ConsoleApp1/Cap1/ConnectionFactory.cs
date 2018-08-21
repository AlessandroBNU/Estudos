using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cap1
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            //conexao.ConnectionString = new LeitorDeConfiguracao().LeConnectionString();
            conexao.Open();

            return conexao;
        }
    }
}
