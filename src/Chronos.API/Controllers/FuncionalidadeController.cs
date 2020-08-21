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
    [Route("api/Funcionalidade")]
    public class FuncionalidadeController : ControllerBase
    {
        private readonly IFuncionalidadeRepository _funcionalidadeRepository;
        private readonly IFuncionalidadeService _funcionalidadeService;
        private readonly IMapper _mapper;
        public FuncionalidadeController(
                                 IFuncionalidadeRepository funcionalidadeRepository,
                                 IFuncionalidadeService funcionalidadeService,
                                 IMapper mapper)
        {
            _funcionalidadeRepository = funcionalidadeRepository;
            _funcionalidadeService = funcionalidadeService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet()]
        public async Task<IEnumerable<FuncionalidadeViewModel>> ObterTodos()
        {
            var returno = _mapper.Map<IEnumerable<FuncionalidadeViewModel>>(await _funcionalidadeRepository.ObterTodos());
            return returno;
        }

        [AllowAnonymous]
        [HttpGet("obter-por-codigofuncionalidade/{projetoId:guid}/{codigoFuncionalidade}")]
        public async Task<IEnumerable<FuncionalidadeViewModel>> ObterPorCodigoFuncionalidade(Guid projetoId,string? codigoFuncionalidade)
        {
            var returno = _mapper.Map<IEnumerable<FuncionalidadeViewModel>>(await _funcionalidadeService.ObterPorCodigoFuncionalidade(codigoFuncionalidade));
            return returno;
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<FuncionalidadeViewModel> Get(Guid id)
        {
            return _mapper.Map<FuncionalidadeViewModel>(await _funcionalidadeRepository.ObterPorId(id));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<FuncionalidadeViewModel>> Post(FuncionalidadeViewModel funcionalidadeViewModel)
        {
            var objeto = _mapper.Map<Funcionalidade>(funcionalidadeViewModel);

            var retorno = _mapper.Map<FuncionalidadeViewModel>(await _funcionalidadeService.Adicionar(objeto));
            return retorno;
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult<FuncionalidadeViewModel>> Put(FuncionalidadeViewModel funcionalidadeViewModel)
        {
            var objeto = _mapper.Map<Funcionalidade>(funcionalidadeViewModel);

            return _mapper.Map<FuncionalidadeViewModel>(await _funcionalidadeService.Atualizar(objeto));
        }

        [AllowAnonymous]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<FuncionalidadeViewModel>> Delete(Guid id)
        {
            return _mapper.Map<FuncionalidadeViewModel>(await _funcionalidadeService.Remover(id));           
        }
    }
}
