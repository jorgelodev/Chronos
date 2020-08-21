using FluentValidation;
using FluentValidation.Results;
using System;

namespace Chronos.Business.Entities
{
    public abstract class Documento: Entity<Documento>
    {
        public string NomeArquivo { get; set; }
        public enum Status
        {
            EDICAO = 0,
            ATIVADO = 1,
            OBSOLETO = 2
        }
        public Status StatusArquivo { get; private set; }

        public Guid FuncionalidadeId { get; set; }
        public virtual Funcionalidade Funcionalidade { get; private set; }

        public override bool EhValido()
        {
            RuleFor(c => c.NomeArquivo)
               .NotEmpty().WithMessage("O Nome do Arquivo precisa ser fornecido");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }

}
