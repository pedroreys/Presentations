using System;

namespace Exemplo.Aplicacao
{
	public interface IHandlerDeMensagem<TMensagem>
	{
		void Handle(TMensagem mensagem);
	}

	public class AlertadorViaSMS : IHandlerDeMensagem<Alerta>
	{
		public void Handle(Alerta alerta)
		{
			Console.WriteLine("Enviando SMS:{0}",alerta.Mensagem);
		}
	}
}