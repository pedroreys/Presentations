using Exemplo.Aplicacao.Model;

namespace Exemplo.Aplicacao
{
	public class Repositorio<T> : IRepositorio<T> where T: new()
	{
		private readonly IConexaoComBd _conexaoComBd;

		public Repositorio(IConexaoComBd conexaoComBd)
		{
			_conexaoComBd = conexaoComBd;
		}

		public T BuscarPeloId(int i)
		{
			_conexaoComBd.GarantirQueEstaConectado();
			return new T();
		}
	}
}