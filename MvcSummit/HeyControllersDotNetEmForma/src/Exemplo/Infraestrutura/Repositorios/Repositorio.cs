using System;
using System.Collections.Generic;
using System.Linq;
using Exemplo.Dominio;
using Exemplo.Dominio.Modelo;
using Exemplo.Dominio.Repositorios;

namespace Exemplo.Infraestrutura.Repositorios
{
	public abstract class Repositorio<T> : IRepositorio<T> where T : Entidade
	{
		protected static List<T> Colecao;

		static Repositorio()
		{
			Colecao = new List<T>();
		}

		public T RetornaPeloId(Guid id)
		{
			return Colecao.SingleOrDefault(x => x.Id == id);
		}

		public void Salvar(T entidade)
		{
			if (!entidade.EhPersistente)
				entidade.Id = Guid.NewGuid();

			if (Colecao.Any(x => x.Id == entidade.Id))
				Colecao.RemoveAll(x => x.Id == entidade.Id);

			Colecao.Add(entidade);
			
		}

		public IEnumerable<T> Todos()
		{
			return Colecao;
		}

		public IQueryable<T> Query()
		{
			return Colecao.AsQueryable();
		}

		public void Remover(T entity)
		{
			Colecao.Remove(entity);
		}
	}
}