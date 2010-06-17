using Exemplo.ResolucaoDeDependencias;

namespace Exemplo.Aplicacao
{
	public class Bus : IBus
	{
		public void Publicar<TMensagem>(TMensagem mensagem)
		{
			var handler = ServiceLocator.Get<IHandlerDeMensagem<TMensagem>>();
			handler.Handle(mensagem);
		}
	}
}