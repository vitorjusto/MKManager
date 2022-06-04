using Guna.UI2.WinForms;

namespace MKManager.View
{
    public partial class TelaMae : Form
    {
        Guna.UI2.WinForms.Guna2GradientButton _ultimoBtn = new Guna2GradientButton();

        public TelaMae() 
        { 
            InitializeComponent();
            _ultimoBtn = btnPaginaInicial;
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnCadastrarClientes.Checked = true;
        }
        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnCadastrarProdutos.Checked = true;
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnPaginaInicial.Checked = true;
        }
        private void btnExibirClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnExibirClientes.Checked = true;
        }
        private void btnExibirProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnExibirProdutos.Checked = true;
        }
        private void btnRelatorioClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnRelatorioClientes.Checked = true;
        }

        private void btnRelatorioProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnRelatorioProdutos.Checked = true;
        }

        private void LimparBotoesAtivos()
        {
            btnPaginaInicial.Checked = false;
            btnCadastrarClientes.Checked = false;
            btnCadastrarProdutos.Checked = false;
            btnExibirClientes.Checked = false;
            btnExibirProdutos.Checked = false;
            btnRelatorioClientes.Checked = false;
            btnRelatorioProdutos.Checked = false;
        }

    }
}