using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Specifications;
using System.Linq;

namespace Chronos.Business.Validations.Menus.Specifications
{
	public class MenuSendoUsadoSpec : ISpecification<Menu>
	{
		private readonly IMenuRepository _menuRepository;
		public MenuSendoUsadoSpec(IMenuRepository menuRepository)
		{
			_menuRepository = menuRepository;
		}
		public bool IsSatisfiedBy(Menu menu)
		{
			return !_menuRepository.ObterPorId(menu.Id).Result.Funcionalidades.Any();			
		}
	}
}
