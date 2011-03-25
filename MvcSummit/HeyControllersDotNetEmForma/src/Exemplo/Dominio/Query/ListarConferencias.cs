using System.Linq;
using Exemplo.Dominio.Modelo;

namespace Exemplo.Dominio.Query
{
	public class ListarConferencias : Query<Conferencia,Conferencia[]>
	{
		private readonly IQueryable<Conferencia> _queryProvider;
		private readonly int _qtdMinPalestras;

		public ListarConferencias(int? qtdMinPalestras, IQueryable<Conferencia> queryProvider)
		{
			_queryProvider = queryProvider;
			_qtdMinPalestras = qtdMinPalestras ?? 0;
		}

		public override Conferencia[] Execute(IQueryable<Conferencia> queryProvider)
		{
			return queryProvider
					.Where(conf => conf.QuantidadeDePalestras >= _qtdMinPalestras)
					.ToArray();
		}
	}
}