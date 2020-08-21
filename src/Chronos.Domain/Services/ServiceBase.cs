using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Chronos.Business.Services
{
	public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
	{
		private readonly IRepositoryBase<TEntity> _repository;
        
        public ServiceBase(IRepositoryBase<TEntity> repository)
		{
			_repository = repository;
		}
		
        public virtual async Task<TEntity> Adicionar(TEntity obj)
		{
			return await _repository.Adicionar(obj);
		}

		public async Task<TEntity> ObterPorId(Guid id)
		{
			return await _repository.ObterPorId(id);
		}

		public async Task<IEnumerable<TEntity>> ObterTodos()
		{
			var todos = await _repository.ObterTodos();
			return todos;
		}

		public virtual async Task<TEntity> Atualizar(TEntity obj)
		{
			return await _repository.Atualizar(obj);
		}

		public virtual async Task<TEntity> Remover(Guid id)
		{
			await _repository.Remover(id);
			return null;
		}

		public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
		{
			return await _repository.Buscar(predicate);
		}

		async Task <int> SaveChanges()
		{
			return await _repository.SaveChanges();
		}
    }
}
