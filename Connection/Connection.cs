using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacao_sozinho.Connection
{
    public class Connection
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdistec"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
