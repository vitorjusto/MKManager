using MKManager.AppService;
using MKManager.Helpers;
using MKManager.Model;

namespace MKManager.View.Cadastrar
{
    public partial class Clientes : Form
    {
        ClienteModel _clienteModel = new();

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _clienteModel.Nome = txtNome.Text;
            _clienteModel.Celular = txtCelular.Text;
            _clienteModel.Email = txtEmail.Text;
            _clienteModel.Cidade = txtCidade.Text;
            _clienteModel.Observacoes = txtObservacoes.Text;

            if (rbMasculino.Checked)
                _clienteModel.Sexo = 'M';
            else if (rbFeminino.Checked)
                _clienteModel.Sexo = 'F';

            try
            {
                ClienteAppService.CadastrarCliente(_clienteModel);
                //_mensagemInfo.Mensagem("Cliente Cadastrado com Sucesso!");

                //Instanciar.LimparCampos(this);
            }
            catch
            {
                //_mensagemErro.Mensagem("Falha no Cadastro!");
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            Instancias.telaCliente.AbrirTelaDeListagem();
        }
    }
}