namespace MKManager.Helpers.Mensagens
{
    public class MensagemAlerta : MensagemMae
    {
        public override void Mensagem(string mensagem)
            => MessageBox.Show(mensagem, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}