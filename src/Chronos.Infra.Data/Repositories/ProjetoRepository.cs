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
    public class ProjetoRepository : RepositoryBase<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(DBContext context)
            : base(context)
        { }

        public override async Task<Projeto> ObterPorId(Guid id)
        {
            return await Db.Projeto.AsNoTracking()
                .Include(m => m.Menus)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
