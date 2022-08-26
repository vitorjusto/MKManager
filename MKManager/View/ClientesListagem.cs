using MKManager.Helpers;
using MKManager.View.Cadastrar;

namespace MKManager.View
{
    public partial class ClientesListagem : Form
    {
        Cadastrar.Clientes cadastrarClientes = new();

        public ClientesListagem()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Instancias.telaCliente.AbrirFormAoPanel(new Clientes());
        }
    }
}