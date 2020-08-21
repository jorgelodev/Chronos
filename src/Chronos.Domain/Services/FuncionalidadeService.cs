using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Services;
using Chronos.Business.Validations.Funcionalidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Business.Services
{
    public class FuncionalidadeService : ServiceBase<Funcionalidade>, IFuncionalidadeService
    {
        private readonly IFuncionalidadeRepository _funcionalidadeRepository;

        public FuncionalidadeService(IFuncionalidadeRepository funcionalidadeRepository)
            :base(funcionalidadeRepository)
        {
            _funcionalidadeRepository = funcionalidadeRepository;
        }

        public async Task<IEnumerable<Funcionalidade>> ObterPorCodigoFuncionalidade(string codigoFuncionalidade)
        {
            return await _funcionalidadeRepository.Buscar(x => x.CodigoFuncionalidade.IdentificacaoCompleta.ToLower().Contains(codigoFuncionalidade.ToLower()));
        }

		public override async Task<Funcionalidade> Adicionar(Funcionalidade objeto)
		{
			if (!objeto.EhValido())
				return objeto;

			objeto.ValidationResult = new FuncionalidadeAptoCadastroValid(_funcionalidadeRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;

			return await _funcionalidadeRepository.Adicionar(objeto);
		}
		public override async Task<Funcionalidade> Atualizar(Funcionalidade objeto)
		{
			if (!objeto.EhValido())
				return objeto;

			objeto.ValidationResult = new FuncionalidadeAptoCadastroValid(_funcionalidadeRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;

			return await _funcionalidadeRepository.Atualizar(objeto);
		}		
    }
}
