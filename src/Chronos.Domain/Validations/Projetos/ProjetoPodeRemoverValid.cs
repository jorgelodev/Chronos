using Chronos.Business.Entities;
using Chronos.Business.Interfaces.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chronos.Business.Validations.Projetos.Specifications
{
	public class MenuPodeRemoverValid : AbstractValidator<Projeto>
	{
		private readonly IProjetoRepository _projetoRepository;
		public MenuPodeRemoverValid(IProjetoRepository projetoRepository)
		{
			_projetoRepository = projetoRepository;

			var Projeto_SendoUsado = new MenuSendoUsadoSpec(projetoRepository);

			RuleFor(x => x).Must(ProjetoSendoUsadoSpec).WithMessage("Projeto sendo usado!");
		}

		public bool ProjetoSendoUsadoSpec(Projeto projeto)
		{
			return new MenuSendoUsadoSpec(_projetoRepository).IsSatisfiedBy(projeto);
		}
	}
}
