using Exemplo.Aplicacao;

namespace Exemplo
{
	class Program
	{
		static void Main(string[] args)
		{
			var enviadorDeEmail = new EnviadorDeEmail();
			var simulador = new Simulador(enviadorDeEmail);
			simulador.Simular();
		}
	}
}
