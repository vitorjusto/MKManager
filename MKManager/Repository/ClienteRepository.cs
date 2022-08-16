using Dapper;
using MKManager.Helpers;
using MKManager.Model;

namespace MKManager.Repository
{
    public class ClienteRepository
    {
        public static void CadastrarCliente(ClienteModel cliente) 
        {
            var query = @"insert into Cliente (Id, Nome, Celular, Email) values (@Id, @Nome, @Celular, @Email)";

            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();

                using var transacao = conexao.BeginTransaction();

                conexao.Execute(query, transacao);
                transacao.Commit();
            }
            catch (Exception ex) { Console.WriteLine($"Erro: {ex}"); }
        }

        public static void ListarClientes() 
        {
            var query = new Sql();

            query.Select("Id, Nome, Celular, Email from Cliente");
            query.OrderBy("Nome asc");

            query.ObterQuery();
        }
        
        public static void AtualizarCliente()
        {
            var query = @"update Cliente set Nome = @Nome, Celular = @Celular, Email = @Email where Id = @Id";
            
            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();
                
                using var transacao = conexao.BeginTransaction();
                
                conexao.Execute(query, transacao);
                transacao.Commit();
            }
            catch(Exception ex) { Console.WriteLine($"Erro: {ex}"); }
        }
        
        public static void ExcluirCliente()
        {
            var query = @"";
            
            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();
                
                using var transacao = conexao.BeginTransaction();
                
                conexao.Execute(query, transacao);
                conexao.Commit();
            }
            catch(Exception ex) { Console.WriteLine($"Erro: {ex}"); }             
        }
    }
}
