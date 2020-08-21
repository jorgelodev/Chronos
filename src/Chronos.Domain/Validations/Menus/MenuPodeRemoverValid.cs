using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chronos.Business.Validations.Menus.Specifications
{
	public class MenuPodeRemoverValid : AbstractValidator<Menu>
	{
		private readonly IMenuRepository _menuRepository;
		public MenuPodeRemoverValid(IMenuRepository menuRepository)
		{
			_menuRepository = menuRepository;

			var Menu_SendoUsado = new MenuSendoUsadoSpec(menuRepository);

			RuleFor(x => x).Must(MenuSendoUsadoSpec).WithMessage("Menu sendo usado!");
		}

		public bool MenuSendoUsadoSpec(Menu menu)
		{
			return new MenuSendoUsadoSpec(_menuRepository).IsSatisfiedBy(menu);
		}
	}
}
