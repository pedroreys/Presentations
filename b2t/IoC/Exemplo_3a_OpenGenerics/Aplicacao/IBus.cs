using System;

namespace Exemplo.Aplicacao
{
	public interface IBus
	{
		void Publicar<TMessage>(TMessage mensagem);
	}
}