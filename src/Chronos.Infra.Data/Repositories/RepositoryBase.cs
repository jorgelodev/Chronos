using Chronos.Business.Interfaces.Repositories;
using Chronos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DBContext Db;
        protected DbSet<TEntity> DbSet;


        public RepositoryBase(DBContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public async Task<TEntity> Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
            await SaveChanges();
            return obj;
        }

        public async Task<TEntity> Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            //DbSet.Update(obj);
            await SaveChanges();
            return obj;
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();         
        }


        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();            
        }

        public virtual async Task Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
