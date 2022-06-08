using MKManager.View;
using MKManager.View.Cadastrar;
using MKManager.View.Exibir;

namespace MKManager.Helpers
{
    internal class Instancias
    {
        public static TelaPrincipal telaPrincipal = new();
        public static CadastrarClientes cadastrarClientes = new();
        public static CadastrarProdutos cadastrarProdutos = new();
        public static ExibirClientes exibirClientes = new();
        public static ExibirProdutos exibirProdutos = new();
    }
}