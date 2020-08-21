using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Infra.Data.Repositories
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DBContext context)
            : base(context)
        { }

        public override async Task<Menu> ObterPorId(Guid id)
        {
            return await Db.Menu.AsNoTracking()
                .Include(m => m.Funcionalidades)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Menu>> ObterPorProjeto(Guid projetoId)
        {
            return await Db.Menu.AsNoTracking()
                .Include(m => m.Funcionalidades)
                .Where(m => m.ProjetoId == projetoId).ToListAsync();
        }
    }
}
