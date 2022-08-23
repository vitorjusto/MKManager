using Guna.UI2.WinForms;

namespace MKManager.Helpers
{
    public class Datas
    {
        public static string VerificarHoraDoDia() 
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                return "Bom dia, Silvia!";

            else if (DateTime.Now.Hour < 18)
                return "Boa tarde, Silvia!";

            else
                return "Boa noite, Silvia!";
        }
    }
}