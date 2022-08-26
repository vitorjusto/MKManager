namespace MKManager.View
{
    public partial class Clientes : Form
    {
        Cadastrar.Clientes cadastrarClientes = new();

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            AdicionarFormAoPanel(cadastrarClientes);
        }

        private void AdicionarFormAoPanel(Form formAtual)
        {
            formAtual.TopLevel = false;
            panelClientes.Controls.Add(formAtual);
            panelClientes.BringToFront();
            formAtual.Show();
        }
    }
}