using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Specifications;
using System.Linq;

namespace Chronos.Business.Validations.Projetos.Specifications
{
	public class MenuSendoUsadoSpec : ISpecification<Projeto>
	{
		private readonly IProjetoRepository _projetoRepository;
		public MenuSendoUsadoSpec(IProjetoRepository projetoRepository)
		{
			_projetoRepository = projetoRepository;
		}
		public bool IsSatisfiedBy(Projeto projeto)
		{
			return !_projetoRepository.ObterPorId(projeto.Id).Result.Menus.Any();			
		}
	}
}
