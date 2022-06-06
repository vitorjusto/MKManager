namespace MKManager.Helpers
{
    internal class Limpar
    {
        public static void GroupBox(Control controle) 
        {
            foreach (Control controlesFilhos in controle.Controls)
            {
                controlesFilhos.ResetText();
                GroupBox(controlesFilhos);
            }
        }
    }
}