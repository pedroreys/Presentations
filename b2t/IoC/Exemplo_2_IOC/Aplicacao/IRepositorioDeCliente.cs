using Exemplo.Aplicacao.Model;

namespace Exemplo.Aplicacao
{
	public interface IRepositorioDeCliente
	{
		Cliente BuscarPeloId(int i);
	}
}