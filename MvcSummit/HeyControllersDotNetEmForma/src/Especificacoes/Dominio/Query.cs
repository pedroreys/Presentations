using System.Linq;

namespace Especificacoes.Dominio
{
	public interface IQuery
	{
		object Execute(IQueryable queryProvider);
	}

	public abstract class Query<TEntity, TResult> : IQuery
	{
		public abstract TResult Execute(IQueryable<TEntity> queryProvider);

		object IQuery.Execute(IQueryable queryProvider)
		{
			return Execute((IQueryable<TEntity>)queryProvider);
		}
	}
}