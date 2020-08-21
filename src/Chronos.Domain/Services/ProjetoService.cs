using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Services;
using Chronos.Business.Validations.Projetos;
using Chronos.Business.Validations.Projetos.Specifications;
using System;
using System.Threading.Tasks;

namespace Chronos.Business.Services
{
    public class ProjetoService : ServiceBase<Projeto>, IProjetoService
	{
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
            :base(projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
		public override async Task<Projeto> Adicionar(Projeto objeto)
		{			
			if (!objeto.EhValido())
				return objeto;

			objeto.ValidationResult = new MenuAptoCadastroValid(_projetoRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;

			return await _projetoRepository.Adicionar(objeto);
		}
		public override async Task<Projeto> Atualizar(Projeto objeto)
		{
			if (!objeto.EhValido())
				return objeto;

			objeto.ValidationResult = new MenuAptoCadastroValid(_projetoRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;

			return await _projetoRepository.Atualizar(objeto);
		}
        public override async Task<Projeto> Remover(Guid id)
		{			
			var objeto = await _projetoRepository.ObterPorId(id);
			objeto.ValidationResult = new MenuPodeRemoverValid(_projetoRepository).Validate(objeto);
			if (!objeto.ValidationResult.IsValid)
				return objeto;
			
			await _projetoRepository.Remover(id);
			return null;
		}
	}
}
