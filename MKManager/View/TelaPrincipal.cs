using MKManager.Helpers;

namespace MKManager.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            lblSaudacao.Text = Datas.VerificarHoraDoDia();
        }
    }
}