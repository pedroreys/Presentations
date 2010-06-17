using System;

namespace Exemplo.Aplicacao
{
	public interface IRegraDeFormatacao 
	{
		string Formatar(string mensagem);
	}

	public class AdicionaDisclaimer : IRegraDeFormatacao
	{
		public string Formatar(string mensagem)
		{
			return mensagem + "\n Essa mensagem se auto-destruirá em 5 segundos!";
		}
	}

	public class ColocaLetrasMaiusculas : IRegraDeFormatacao
	{
		public string Formatar(string mensagem)
		{
			return mensagem.ToUpper();
		}
	}
}