using Exemplo.Dominio.Modelo;

namespace Exemplo.Dominio.Repositorios
{
	public interface IRepositorioDeConferencias : IRepositorio<Conferencia>
	{
		Conferencia RetornaPeloNome(string nome);
	}
}