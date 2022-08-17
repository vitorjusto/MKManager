using MKManager.Model;
using MKManager.Repository;

namespace MKManager.AppService
{
    public class ProdutoAppService
    {
        public void CadastrarProduto(ProdutoModel produto) => ProdutoRepository.CadastrarProduto(produto);
        public void ListarProdutos() => ProdutoRepository.ListarProdutos();
        public void AtualizarProduto(ProdutoModel produto) => ProdutoRepository.AtualizarProduto(produto);
        public void ExcluirProduto(ProdutoModel produto) => ProdutoRepository.ExcluirProduto(produto);
    }
}