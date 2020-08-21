using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Validations.Projetos.Specifications;
using FluentValidation;

namespace Chronos.Business.Validations.Projetos
{
	public class MenuAptoCadastroValid : AbstractValidator<Projeto>
	{
		private readonly IProjetoRepository _projetoRepository;
		public MenuAptoCadastroValid(IProjetoRepository projetoRepository)
		{
			_projetoRepository = projetoRepository;

			RuleFor(x => x).Must(ObjetoDeveSerUnico).WithMessage("Projeto com Código já existente!");
		}

		public bool ObjetoDeveSerUnico(Projeto projeto)
		{
			var objeto = new MenuDeveSerUnicoSpec(_projetoRepository).IsSatisfiedBy(projeto);
			return objeto;
		}
	}
}
