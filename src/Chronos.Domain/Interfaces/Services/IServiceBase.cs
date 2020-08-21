using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Chronos.Business.Interfaces.Services
{
	public interface IServiceBase<TEntity> where TEntity : class
	{
		Task<TEntity> Adicionar(TEntity obj);
		Task<TEntity> ObterPorId(Guid id);
		Task<IEnumerable<TEntity>> ObterTodos();
		Task<TEntity> Atualizar(TEntity obj);
		Task<TEntity> Remover(Guid id);
		Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
	}
}
