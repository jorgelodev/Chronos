using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Validations.Funcionalidades.Specifications;
using FluentValidation;

namespace Chronos.Business.Validations.Funcionalidades
{
	public class FuncionalidadeAptoCadastroValid : AbstractValidator<Funcionalidade>
	{
		private readonly IFuncionalidadeRepository _funcionalidadeRepository;
		public FuncionalidadeAptoCadastroValid(IFuncionalidadeRepository funcionalidadeRepository)
		{
			_funcionalidadeRepository = funcionalidadeRepository;

			RuleFor(x => x).Must(ObjetoDeveSerUnico).WithMessage("Funcionalidade com Código já existente!");
		}

		public bool ObjetoDeveSerUnico(Funcionalidade funcionalidade)
		{
			return new FuncionalidadeDeveSerUnicoSpec(_funcionalidadeRepository).IsSatisfiedBy(funcionalidade);
		}
	}
}
