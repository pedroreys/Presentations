namespace Exemplo.Aplicacao
{
	public class Simulador : ISimulador
	{
		private EnviadorDeEmail _enviadorDeEmail;

		public Simulador(EnviadorDeEmail enviadorDeEmail)
		{
			_enviadorDeEmail = enviadorDeEmail;
		}

		public void Simular()
		{
			_enviadorDeEmail.Enviar("simulado!");
		}
	}
}