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
    [Route("api/Entidade")]
    public class EntidadeController : ControllerBase
    {
        private readonly IEntidadeRepository _entidadeRepository;
        private readonly IEntidadeService _entidadeService;
        private readonly IMapper _mapper;
        public EntidadeController(
                                 IEntidadeRepository projetoRepository,
                                 IEntidadeService projetoService,
                                 IMapper mapper)
        {
            _entidadeRepository = projetoRepository;
            _entidadeService = projetoService;
            _mapper = mapper;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<EntidadeViewModel>> Get()
        {
            return _mapper.Map<IEnumerable<EntidadeViewModel>>(await _entidadeRepository.ObterTodos());
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<EntidadeViewModel> Get(Guid id)
        {
            return _mapper.Map<EntidadeViewModel>(await _entidadeRepository.ObterPorId(id));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<EntidadeViewModel>> Post(EntidadeViewModel entidadeViewModel)
        {
            var objeto = _mapper.Map<Projeto>(entidadeViewModel);

            var retorno = _mapper.Map<EntidadeViewModel>(await _entidadeService.Adicionar(objeto));
            return retorno;
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult<EntidadeViewModel>> Put(EntidadeViewModel entidadeViewModel)
        {
            var objeto = _mapper.Map<Projeto>(entidadeViewModel);

            return _mapper.Map<EntidadeViewModel>(await _entidadeService.Atualizar(objeto));
        }

        [AllowAnonymous]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<EntidadeViewModel>> Delete(Guid id)
        {
            return _mapper.Map<EntidadeViewModel>(await _entidadeService.Remover(id));           
        }
    }
}
