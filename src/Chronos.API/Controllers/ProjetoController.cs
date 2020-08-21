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
    [Route("api/projeto")]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IProjetoService _projetoService;
        private readonly IMapper _mapper;
        public ProjetoController(
                                 IProjetoRepository projetoRepository,
                                 IProjetoService projetoService,
                                 IMapper mapper)
        {
            _projetoRepository = projetoRepository;
            _projetoService = projetoService;
            _mapper = mapper;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<ProjetoViewModel>> Get()
        {
            return _mapper.Map<IEnumerable<ProjetoViewModel>>(await _projetoRepository.ObterTodos());
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ProjetoViewModel> Get(Guid id)
        {
            return _mapper.Map<ProjetoViewModel>(await _projetoRepository.ObterPorId(id));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<ProjetoViewModel>> Post(ProjetoViewModel projetoViewModel)
        {
            var objeto = _mapper.Map<Projeto>(projetoViewModel);

            var retorno = _mapper.Map<ProjetoViewModel>(await _projetoService.Adicionar(objeto));
            return retorno;
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult<ProjetoViewModel>> Put(ProjetoViewModel projetoViewModel)
        {
            var objeto = _mapper.Map<Projeto>(projetoViewModel);

            return _mapper.Map<ProjetoViewModel>(await _projetoService.Atualizar(objeto));
        }

        [AllowAnonymous]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProjetoViewModel>> Delete(Guid id)
        {
            return _mapper.Map<ProjetoViewModel>(await _projetoService.Remover(id));           
        }
    }
}
