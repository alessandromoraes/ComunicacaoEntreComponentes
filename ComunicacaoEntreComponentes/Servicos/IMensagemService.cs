namespace ComunicacaoEntreComponentes.Servicos
{
	public interface IMensagemService
	{
		event Action<string> OnMensagem;
		void EnviaMensagem(string message);
		void LimpaMensagens();
	}
}
