using System.Linq;
using Exemplo.Dominio.Modelo;
using Exemplo.Dominio.Repositorios;

namespace Exemplo.Infraestrutura.Repositorios
{
	public class RepositorioDeConferencias : Repositorio<Conferencia>, IRepositorioDeConferencias
	{
		public Conferencia RetornaPeloNome(string nome)
		{
			return Colecao.FirstOrDefault(x => x.Nome == nome);
		}
	}
}