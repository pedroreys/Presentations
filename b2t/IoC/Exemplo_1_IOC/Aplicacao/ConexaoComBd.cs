using System;

namespace Exemplo.Aplicacao
{
	public class ConexaoComBd : IConexaoComBd
	{
		public void GarantirQueEstaConectado()
		{
			Console.WriteLine("Conexão com o Banco: Conectado!");
		}
	}
}