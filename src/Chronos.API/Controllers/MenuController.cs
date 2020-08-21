using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Chronos.API.ViewModels;
using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chronos.Services.Controllers
{
    [ApiController]
    [Route("api/menu")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;
        public MenuController(
                                 IMenuRepository menuRepository,
                                 IMenuService menuService,
                                 IMapper mapper)
        {
            _menuRepository = menuRepository;
            _menuService = menuService;
            _mapper = mapper;
        }
        [AllowAnonymous]
        [HttpGet("obter-por-projeto/{projetoId:guid}")]
        public async Task<IEnumerable<MenuViewModel>> ObterPorProjeto(Guid projetoId)
        {
            var returno= _mapper.Map<IEnumerable<MenuViewModel>>(await _menuRepository.ObterPorProjeto(projetoId));
            return returno;
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<MenuViewModel> Get(Guid id)
        {
            return _mapper.Map<MenuViewModel>(await _menuRepository.ObterPorId(id));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<MenuViewModel>> Post(MenuViewModel menuViewModel)
        {
            var objeto = _mapper.Map<Menu>(menuViewModel);

            var retorno = _mapper.Map<MenuViewModel>(await _menuService.Adicionar(objeto));
            return retorno;
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult<MenuViewModel>> Put(MenuViewModel menuViewModel)
        {
            var objeto = _mapper.Map<Menu>(menuViewModel);

            var retorno = _mapper.Map<MenuViewModel>(await _menuService.Atualizar(objeto));
            return retorno;
        }

        [AllowAnonymous]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<MenuViewModel>> Delete(Guid id)
        {
            return _mapper.Map<MenuViewModel>(await _menuService.Remover(id));           
        }
    }
}
