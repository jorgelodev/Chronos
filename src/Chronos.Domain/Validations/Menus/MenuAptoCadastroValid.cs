using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Validations.Menus.Specifications;
using FluentValidation;

namespace Chronos.Business.Validations.Menus
{
	public class MenuAptoCadastroValid : AbstractValidator<Menu>
	{
		private readonly IMenuRepository _menuRepository;
		public MenuAptoCadastroValid(IMenuRepository menuRepository)
		{
			_menuRepository = menuRepository;

			RuleFor(x => x).Must(ObjetoDeveSerUnico).WithMessage("Menu com Código já existente!");
		}

		public bool ObjetoDeveSerUnico(Menu menu)
		{
			var objeto = new MenuDeveSerUnicoSpec(_menuRepository).IsSatisfiedBy(menu);
			return objeto;
		}
	}
}
