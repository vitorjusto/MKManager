using MKManager.View;
using MKManager.View.Cadastrar;

namespace MKManager.Helpers
{
    internal class Instancias
    {
        public static TelaPrincipal telaPrincipal;
        public static ClientesBase telaCliente;
        public static Produtos telaProduto;
        public static Relatorios telaRelatorio;
        public static Ajuda telaAjuda;

        public static TelaPrincipal ObterTelaPrincipal() 
        {
            if (telaPrincipal is null)
                telaPrincipal = new TelaPrincipal();
            
            return telaPrincipal;
        }

        public static ClientesBase ObterTelaCliente()
        {
            if (telaCliente is null)
                telaCliente = new ClientesBase();

            return telaCliente;
        }

        public static Produtos ObterTelaProduto() 
        {
            if(telaProduto is null)
                telaProduto = new Produtos();

            return telaProduto;
        }

        public static Relatorios ObterTelaRelatorio()
        {
            if (telaRelatorio is null)
                telaRelatorio = new Relatorios();

            return telaRelatorio;
        }

        public static Ajuda ObterTelaAjuda()
        {
            if (telaAjuda is null)
                telaAjuda = new Ajuda();

            return telaAjuda;
        }
    }
}