using System;

namespace Exemplo.Aplicacao
{
	public class EnviadorDeEmail : IEnviadorDeEmail
	{
		public void Enviar(string mensagem)
		{
			Console.WriteLine("Enviador De Email: \"{0}\" foi enviado.",mensagem);
		}
	}
}