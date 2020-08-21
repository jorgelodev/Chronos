using Chronos.Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chronos.Business.Interfaces.Services
{
    public interface IFuncionalidadeService : IServiceBase<Funcionalidade>
    {
        Task<IEnumerable<Funcionalidade>> ObterPorCodigoFuncionalidade(string codigoFuncionalidade);
    }
}
