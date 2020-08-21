using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Business.Interfaces.Repositories
{
	public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
	{
		Task<TEntity> Adicionar(TEntity obj);
		Task<TEntity> ObterPorId(Guid id);
		Task<IEnumerable<TEntity>> ObterTodos();
		Task<TEntity> Atualizar(TEntity obj);
		Task Remover(Guid id);
		Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);		
		Task<int> SaveChanges();
	}
}
