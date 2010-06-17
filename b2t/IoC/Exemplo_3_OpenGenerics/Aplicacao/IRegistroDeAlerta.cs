using System;

namespace Exemplo.Aplicacao
{
	public interface IRegistroDeAlerta
	{
		void RegistrarAlerta();
	}

	public class RegistroDeAlerta : IRegistroDeAlerta
	{
		public void RegistrarAlerta()
		{
			Console.WriteLine("Registro de Alerta: Alerta Registrado!");
		}
	}
}