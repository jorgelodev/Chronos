using Chronos.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Business.Interfaces.Repositories
{
    public interface IMenuRepository : IRepositoryBase<Menu>
    {
        Task<IEnumerable<Menu>> ObterPorProjeto(Guid projetoId);
    }
}
