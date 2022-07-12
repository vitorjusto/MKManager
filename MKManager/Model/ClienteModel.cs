namespace MKManager.Model
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string? Celular { get; set; }
        public string? Email { get; set; }
        public string? Cidade { get; set; }
        public string? Observacoes { get; set; }
    }
}