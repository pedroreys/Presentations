namespace Exemplo.Aplicacao
{
	public class Alerta
	{
		public Alerta(string mensagem)
		{
			Mensagem = mensagem;
		}
		
		public string Mensagem { get; private set; }
	}
}