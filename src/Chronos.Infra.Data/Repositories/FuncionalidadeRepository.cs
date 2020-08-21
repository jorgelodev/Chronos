using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Infra.Data.Repositories
{
    public class FuncionalidadeRepository : RepositoryBase<Funcionalidade>, IFuncionalidadeRepository
    {
        public FuncionalidadeRepository(DBContext context)
            : base(context)
        {
        }

        public override async Task<IEnumerable<Funcionalidade>> ObterTodos()
        {
            return await DbSet
                .Include(x=>x.Projeto)
                .Include(x=>x.Menu)
                .ToListAsync();
        }
        public async Task<IEnumerable<Funcionalidade>> ObterPorCodigoFuncionalidade(Guid projetoId,string codigoFuncionalidade)
        {
            return await Buscar(x => x.ProjetoId == projetoId);// && x.CodigoFuncionalidade.IdentificacaoCompleta.Contains(codigoFuncionalidade));
        }
    }
}
