using Exemplo.Aplicacao;
using Exemplo.ResolucaoDeDependencias;

namespace Exemplo
{
	class Program
	{
		static void Main(string[] args)
		{
			var simulador = ServiceLocator.Get<ISimulador>();
			simulador.Simular();
		}
	}
}
