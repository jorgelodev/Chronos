using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Specifications;
using System.Linq;

namespace Chronos.Business.Validations.Funcionalidades.Specifications
{   
	public class FuncionalidadeDeveSerUnicoSpec : ISpecification<Funcionalidade>
	{
		private readonly IFuncionalidadeRepository _funcionalidadeRepository;
		public FuncionalidadeDeveSerUnicoSpec(IFuncionalidadeRepository funcionalidadeRepository)
		{
			_funcionalidadeRepository = funcionalidadeRepository;
		}
		public bool IsSatisfiedBy(Funcionalidade funcionalidade)
		{
			return _funcionalidadeRepository.Buscar(c => c.CodigoFuncionalidade.IdentificacaoCompleta.Equals(funcionalidade.CodigoFuncionalidade.IdentificacaoCompleta) 
			&& c.Id != funcionalidade.Id) == null;
		}
	}
}
