namespace MKManager.ValueObjects
{
    public struct Celular
    {
        private readonly string _numero;

        public Celular(string numero) => _numero = numero;

        public string ComDDI()
        {
            if (_numero.Contains("+55")) return _numero;

            return $"+55 {_numero}";
        }

        public string SemDDI()
        {
            var verificarSeContemDDI = _numero.Contains("+55");

            if (verificarSeContemDDI) return _numero.Trim().Substring(3);

            return _numero;
        }

        public static implicit operator Celular(string numero) => new(numero);
    }
}