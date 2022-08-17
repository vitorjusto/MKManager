using MKManager.ValueObjects;

namespace MKManager.Model
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public Dinheiro PrecoDeCusto { get; set; }
        public Dinheiro PrecoDeVenda { get; set; }
        public int Estoque { get; set; }
    }
}
