using Exemplo.Aplicacao.Model;

namespace Exemplo.Aplicacao
{
	public class Simulador : ISimulador
	{
		private readonly IEnviadorDeEmail _enviadorDeEmail;
		private readonly IRegistroDeAlerta _registroDeAlerta;
		private readonly IRepositorio<Cliente> _repositorioDeCliente;

		public Simulador(IEnviadorDeEmail enviadorDeEmail, IRegistroDeAlerta registroDeAlerta, IRepositorio<Cliente> repositorioDeCliente)
		{
			_enviadorDeEmail = enviadorDeEmail;
			_registroDeAlerta = registroDeAlerta;
			_repositorioDeCliente = repositorioDeCliente;
		}

		public void Simular()
		{
			_registroDeAlerta.RegistrarAlerta();
			Cliente cliente = _repositorioDeCliente.BuscarPeloId(1);
			var mensagem = string.Format("simulação para {0}.", cliente.Nome);
			_enviadorDeEmail.Enviar(mensagem);
		}
	}
}