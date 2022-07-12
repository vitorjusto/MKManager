namespace MKManager.Helpers.Mensagens
{
    public class MensagemErro : MensagemMae
    {
        public override void Mensagem(string mensagem)
            => MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}