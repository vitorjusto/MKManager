namespace MKManager.Helpers
{
    internal class Limpar
    {
        public static void TodosOsCampos(Control controles) 
        {
            foreach (var item in controles.Controls)
            {
                CampoEspecifico((Control)item);
            }
        }

        public static void CampoEspecifico(Control controle)
        {

            if (controle is TextBox || controle is ComboBox)
                controle.Text = string.Empty;

            if (controle is RadioButton radioButton)
                radioButton.Checked = false;

            if(controle is CheckBox checkBox)
                checkBox.Checked = false;
        }
    }
}