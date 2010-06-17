namespace Exemplo.Aplicacao
{
	public class RepositorioDeCliente : IRepositorioDeCliente
	{
		private readonly IConexaoComBd _conexaoComBd;

		public RepositorioDeCliente(IConexaoComBd conexaoComBd)
		{
			_conexaoComBd = conexaoComBd;
		}

		public Cliente BuscarPeloId(int i)
		{
			_conexaoComBd.GarantirQueEstaConectado();
			return new Cliente();
		}
	}
}