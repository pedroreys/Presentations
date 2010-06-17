using System;

namespace Exemplo.Aplicacao
{
	public class EnviadorDeEmail : IEnviadorDeEmail
	{
		private readonly IFormatadorDeMensagem _formatadorDeMensagem;

		public EnviadorDeEmail(IFormatadorDeMensagem formatadorDeMensagem)
		{
			_formatadorDeMensagem = formatadorDeMensagem;
		}

		public void Enviar(string mensagem)
		{
			string formatada = _formatadorDeMensagem.Formatar(mensagem);
			Console.WriteLine("Enviador De Email: \"{0}\" foi enviado.", formatada);
		}
	}
}