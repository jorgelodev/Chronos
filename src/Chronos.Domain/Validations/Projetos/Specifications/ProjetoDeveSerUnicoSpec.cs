using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Specifications;
using System.Linq;

namespace Chronos.Business.Validations.Projetos.Specifications
{   
	public class MenuDeveSerUnicoSpec : ISpecification<Projeto>
	{
		private readonly IProjetoRepository _projetoRepository;
		public MenuDeveSerUnicoSpec(IProjetoRepository projetoRepository)
		{
			_projetoRepository = projetoRepository;
		}
		public bool IsSatisfiedBy(Projeto projeto)
		{
			return !_projetoRepository.Buscar(c => c.Prefixo.Equals(projeto.Prefixo) && c.Id != projeto.Id).Result.Any();
		}
	}
}
