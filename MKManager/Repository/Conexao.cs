using System.Data;
using System.Data.SqlClient;

namespace MKManager.Repository
{
    public class Conexao
    {
        const string connectionString = @"";

        //public static SqlConnection conexao;

        public static IDbConnection Conectar() => new SqlConnection(connectionString);
    }
}