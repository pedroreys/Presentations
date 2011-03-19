using System;
using System.Collections.Generic;
using System.Linq;
using Exemplo.Dominio.Modelo;

namespace Exemplo.Dominio.Repositorios
{
	public interface IRepositorio<T> where T : Entidade
	{
		T RetornaPeloId(Guid id);
		void Salvar(T entidade);
		IEnumerable<T> Todos();
		IQueryable<T> Query();
			void Remover(T entity);
	}
}