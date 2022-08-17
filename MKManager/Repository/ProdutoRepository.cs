using Dapper;
using MKManager.Helpers;
using MKManager.Model;

namespace MKManager.Repository
{
    public class ProdutoRepository
    {
        public static void CadastrarProduto(ProdutoModel produto)
        {
            var query = @"";

            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();

                using var transacao = conexao.BeginTransaction();

                conexao.Execute(query, produto, transacao);
                transacao.Commit();
            }
            catch (Exception ex) { Console.WriteLine($"Erro: {ex.Message}"); }
        }

        public static void ListarProdutos()
        {
            var query = new Sql();

            query.Select("IdProduto, Categoria, Nome, PrecoDeCusto, PrecoDeVenda, Estoque from Produto");
            query.OrderBy("Nome asc");

            query.ObterQuery();
        }

        public static void AtualizarProduto(ProdutoModel produto) 
        {
            var query = @"";

            try 
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();

                using var transacao = conexao.BeginTransaction();

                conexao.Execute(query, produto, transacao);
                transacao.Commit();
            }
            catch (Exception ex) { Console.WriteLine($"Erro: {ex.Message}"); }
        }

        public static void ExcluirProduto(ProdutoModel produto) 
        {
            var query = @"delete from Produto where IdProduto = @IdProduto";

            try
            {
                using var conexao = Conexao.Conectar();
                conexao.Open();

                using var transacao = conexao.BeginTransaction();

                conexao.Execute(query, produto, transacao);
                transacao.Commit();
            }
            catch (Exception ex) { Console.WriteLine($"Erro: {ex.Message}"); }
        }
    }
}