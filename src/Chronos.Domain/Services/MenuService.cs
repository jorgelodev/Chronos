using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Services;
using Chronos.Business.Validations.Menus;
using Chronos.Business.Validations.Menus.Specifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chronos.Business.Services
{
    public class MenuService : ServiceBase<Menu>, IMenuService
	{
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
            :base(menuRepository)
        {
            _menuRepository = menuRepository;
        }
		public override async Task<Menu> Adicionar(Menu objeto)
		{			
			if (!objeto.EhValido())
				return objeto;

			objeto.ValidationResult = new MenuAptoCadastroValid(_menuRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;

			return await _menuRepository.Adicionar(objeto);
		}
		public override async Task<Menu> Atualizar(Menu objeto)
		{
			if (!objeto.EhValido())
				return objeto;

			objeto.ValidationResult = new MenuAptoCadastroValid(_menuRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;

			var returno = await _menuRepository.Atualizar(objeto);
			return returno;
		}

        public override async Task<Menu> Remover(Guid id)
		{			
			var objeto = await _menuRepository.ObterPorId(id);
			objeto.ValidationResult = new MenuPodeRemoverValid(_menuRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;
			
			await _menuRepository.Remover(id);
			return null;
		}
	}
}
