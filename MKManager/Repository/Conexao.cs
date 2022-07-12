using System.Data;
using System.Data.SqlClient;

namespace MKManager.Repository
{
    public class Conexao
    {
        const string connectionString = @"";

        public static SqlConnection? conexao = null;

        public IDbConnection Conectar() => new SqlConnection(connectionString);
    }
}