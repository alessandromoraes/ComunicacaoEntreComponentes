
namespace ComunicacaoEntreComponentes.Servicos
{
	public class MensagemService : IMensagemService
	{
		public event Action<string>? OnMensagem;

		public void EnviaMensagem(string message)
		{
			OnMensagem?.Invoke(message);
		}

		public void LimpaMensagens()
		{
			OnMensagem?.Invoke(null);
		}
	}
}
