using Dapper;
using MKManager.Helpers;
using MKManager.Model;
using MKManager.Model.Result;

namespace MKManager.Repository
{
    public class ClienteRepository
    {
        public static void CadastrarCliente(ClienteModel cliente) 
        {
            var query = @"insert into Cliente (IdCliente, Nome, Celular, Email, Cidade, Sexo, Observacoes) 
                        values (@IdCliente, @Nome, @Celular, @Email, @Cidade, @Sexo, @Observacoes)";

            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();

                using var transacao = conexao.BeginTransaction();

                conexao.Execute(query, cliente, transacao);
                transacao.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static IEnumerable<ListagemClienteResult> ListarClientes()
        {
            var query = new Sql();

            try 
            {
                query.Select("IdCliente, Nome, Celular, Email, Cidade, Sexo, Observacoes from Cliente");
                query.OrderBy("Nome asc");

                using var conexao = Conexao.Conectar();
                return conexao.Query<ListagemClienteResult>(query.ObterQuery());
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        
        public static void AtualizarCliente(ClienteModel cliente)
        {
            var query = @"update Cliente set Nome = @Nome, Celular = @Celular, Email = @Email, Cidade = @Cidade, Sexo = @Sexo,
                        Observacoes = @Observacoes where IdCliente = @IdCliente";
            
            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();
                
                using var transacao = conexao.BeginTransaction();
                
                conexao.Execute(query, cliente, transacao);
                transacao.Commit();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public static void ExcluirCliente(ClienteModel cliente)
        {
            var query = @"delete from Cliente where IdCliente = @IdCliente";
            
            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();
                
                using var transacao = conexao.BeginTransaction();
                
                conexao.Execute(query, cliente, transacao);
                transacao.Commit();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}