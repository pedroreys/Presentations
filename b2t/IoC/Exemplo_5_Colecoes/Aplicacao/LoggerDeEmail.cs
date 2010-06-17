using System;

namespace Exemplo.Aplicacao
{
	public class LoggerDeEmail : IEnviadorDeEmail
	{
		private readonly IEnviadorDeEmail _interno;

		public LoggerDeEmail(IEnviadorDeEmail interno)
		{
			_interno = interno;
		}

		public void Enviar(string mensagem)
		{
			_interno.Enviar(mensagem);
			Console.WriteLine("Logger de Email: Logado.");
		}
	}
}