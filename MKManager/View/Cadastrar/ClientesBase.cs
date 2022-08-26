
namespace MKManager.View.Cadastrar
{
    public partial class ClientesBase : Form
    {
        private ClientesListagem _listagem { get; set; } //deixar instanciada para evitar varias consulta no banco

        public ClientesBase()
        {
            InitializeComponent();
        }

        public void AbrirFormAoPanel(Form formAtual)
        {
            formAtual.TopLevel = false;
            pnBase.Controls.Clear();
            pnBase.Controls.Add(formAtual);
            formAtual.BringToFront();
            formAtual.Show();
        }

        private void ClientesBase_Load(object sender, EventArgs e)
        {
            _listagem = new ClientesListagem();
            AbrirTelaDeListagem();
        }


        public void AbrirTelaDeListagem()
        {
            AbrirFormAoPanel(_listagem);
        }

    }
}
