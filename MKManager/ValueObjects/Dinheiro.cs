namespace MKManager.ValueObjects
{
    public struct Dinheiro
    {
        private readonly decimal _dinheiro;

        public Dinheiro(decimal dinheiro) => _dinheiro = dinheiro;
        public Dinheiro(string dinheiro) => _dinheiro = Convert.ToDecimal(dinheiro);

        public override string ToString()
        {
            return _dinheiro.ToString("c");
        }

        public decimal ToDecimal() 
        {
            return _dinheiro;
        }

        public static implicit operator Dinheiro(decimal dinheiro) => new(dinheiro);
        public static implicit operator Dinheiro(string dinheiro) => new(dinheiro);
    }
}