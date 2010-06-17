using System;

namespace Exemplo.Aplicacao
{
	public interface IRegistroDeAlerta
	{
		void RegistrarAlerta();
	}

	public class RegistroDeAlerta : IRegistroDeAlerta
	{
		private readonly IBus _bus;

		public RegistroDeAlerta(IBus bus)
		{
			_bus = bus;
		}

		public void RegistrarAlerta()
		{
			_bus.Publicar(new Alerta("Registro de Alerta: Alertado!"));
		}
	}
}