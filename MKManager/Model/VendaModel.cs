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
        public int QuantidadeTotalDeProdutosNaVenda { get => Produtos.Sum(x => x.QuantidadeDeProdutosNaVenda); }

        public void AdicionarProduto(ProdutoModel produto) => Produtos.Add(produto);
    }
}