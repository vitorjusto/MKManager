using MKManager.Helpers;

namespace MKManager.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            Datas.VerificarHoraDoDia(lblBomDiaBoaTardeBoaNoite);
        }
    }
}