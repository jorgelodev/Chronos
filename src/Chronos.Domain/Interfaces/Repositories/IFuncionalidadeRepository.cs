using Chronos.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Business.Interfaces.Repositories
{
    public interface IFuncionalidadeRepository:IRepositoryBase<Funcionalidade>
    {
        Task<IEnumerable<Funcionalidade>> ObterPorCodigoFuncionalidade(string codigoFuncionalidade);
    }
}
