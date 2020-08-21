using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Specifications;
using System.Linq;

namespace Chronos.Business.Validations.Menus.Specifications
{   
	public class MenuDeveSerUnicoSpec : ISpecification<Menu>
	{
		private readonly IMenuRepository _menuRepository;
		public MenuDeveSerUnicoSpec(IMenuRepository menuRepository)
		{
			_menuRepository = menuRepository;
		}
		public bool IsSatisfiedBy(Menu menu)
		{
			return !_menuRepository.Buscar(c => c.Prefixo.Equals(menu.Prefixo)  && c.Id != menu.Id && c.ProjetoId == menu.ProjetoId).Result.Any();
		}
	}
}
