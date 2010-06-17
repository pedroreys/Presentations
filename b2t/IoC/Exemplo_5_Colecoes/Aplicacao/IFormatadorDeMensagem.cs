using System;

namespace Exemplo.Aplicacao
{
	public interface IFormatadorDeMensagem
	{
		string Formatar(string mensagem);
	}

	public class FormatadorDeMensagem : IFormatadorDeMensagem
	{
		private readonly IRegraDeFormatacao[] _regras;

		public FormatadorDeMensagem(IRegraDeFormatacao[] regras)
		{
			_regras = regras;
		}

		public string Formatar(string mensagem)
		{
			foreach (IRegraDeFormatacao regra in _regras)
			{
				mensagem = regra.Formatar(mensagem);
			}
			return mensagem;
		}
	}
}