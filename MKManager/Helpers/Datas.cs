using Guna.UI2.WinForms;

namespace MKManager.Helpers
{
    public class Datas
    {
        public static void VerificarHoraDoDia(Guna2HtmlLabel label) 
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                label.Text = "Bom dia, Marina Silva!";

            else if (DateTime.Now.Hour < 18)
                label.Text = "Boa tarde, Marina Silva!";

            else
                label.Text = "Boa noite, Marina Silva!";
        }
    }
}