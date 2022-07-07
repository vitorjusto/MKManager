using MKManager.ValueObjects;

namespace MKManager.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Dinheiro PrecoCusto { get; set; }
        public Dinheiro PrecoVenda { get; set; }
        public int Estoque { get; set; }
    }
}