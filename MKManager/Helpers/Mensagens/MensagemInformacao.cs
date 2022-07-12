namespace MKManager.Helpers.Mensagens
{
    public class MensagemInformacao : MensagemMae
    {
        public override void Mensagem(string mensagem)
            => MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}