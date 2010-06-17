using System;

namespace Exemplo.Aplicacao
{
	public interface IConexaoComBd
	{
		void GarantirQueEstaConectado();
	}

	public class ConexaoComBd : IConexaoComBd
	{
		public void GarantirQueEstaConectado()
		{
			Console.WriteLine("Conexão com o Banco: Conectado!");
		}
	}

	public class ConexaoComOracle : IConexaoComBd
	{
		private readonly string _connectionString;

		public ConexaoComOracle(string connectionString)
		{
			_connectionString = connectionString;
		}

		public void GarantirQueEstaConectado()
		{
			Console.WriteLine("Conexão de Banco de Dados Oracle: Conectado a {0}",_connectionString);
		}
	}
}