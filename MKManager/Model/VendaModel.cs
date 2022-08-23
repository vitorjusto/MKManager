using MKManager.ValueObjects;

namespace MKManager.Model
{
    public class VendaModel
    {
        private List<ProdutoModel> Produtos { get; set; }
        public VendaModel() => Produtos = new List<ProdutoModel>();

        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public string FormaDePagamento { get; set; }
        public Dinheiro TotalBruto { get; set; }
        public Dinheiro TotalLiquido { get; set; }

        public void AdicionarProduto(ProdutoModel produto) => Produtos.Add(produto);
    }
}
