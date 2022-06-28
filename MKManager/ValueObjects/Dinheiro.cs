namespace MKManager.ValueObjects
{
    public struct Dinheiro
    {
        private readonly decimal _dinheiro;

        public Dinheiro(decimal dinheiro) => _dinheiro = dinheiro;

        public override string ToString()
        {
            return _dinheiro.ToString("c");
        }

        public static implicit operator Dinheiro(decimal dinheiro) => new Dinheiro(dinheiro);
    }
}