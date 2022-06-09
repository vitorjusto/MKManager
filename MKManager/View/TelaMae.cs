using MKManager.Helpers;

namespace MKManager.View
{
    public partial class TelaMae : Form
    {
        public TelaMae() => InitializeComponent();

        private void TelaMae_Load(object sender, EventArgs e) => AdicionarFormAoPanel(Instancias.telaPrincipal);

        private void LimparBotoesAtivos()
        {
            btnPaginaInicial.Checked = false;
            btnClientes.Checked = false;
            btnProdutos.Checked = false;
            btnRelatorios.Checked = false;
            btnAjuda.Checked = false;
        }

        private void AdicionarFormAoPanel(Form formAtual) 
        {
            formAtual.TopLevel = false;
            panelFormAtual.Controls.Add(formAtual);
            formAtual.BringToFront();
            formAtual.Show();
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnPaginaInicial.Checked = true;
            AdicionarFormAoPanel(Instancias.telaPrincipal);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnClientes.Checked = true;
            AdicionarFormAoPanel(Instancias.telaCliente);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnProdutos.Checked = true;
            AdicionarFormAoPanel(Instancias.telaProduto);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            LimparBotoesAtivos();
            btnRelatorios.Checked = true;
            AdicionarFormAoPanel(Instancias.telaRelatorio);
        }
    }
}