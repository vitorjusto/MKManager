namespace MKManager.Model
{
    public class VendaModel
    {
        public List<ProdutoVendaModel> Produtos { get; set; }

        public void AdicionarProduto(ProdutoVendaModel produto) => Produtos.Add(produto);

        public VendaModel()
        {
            Produtos = new List<ProdutoVendaModel>();
        }

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public string FormaDePagamento { get; set; }
        public int QuantidadeDeProdutos { get => Produtos.Sum(x => x.Quantidade); }
    }
}