using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Chronos.Business.Entities
{
    public class Funcionalidade : Entity<Funcionalidade>
    {
        protected Funcionalidade()
        {
        }
        public Funcionalidade(
            Guid projetoId,
            Guid menuId,
            Guid funcionalidadePaiId,
            CodigoFuncionalidade codigoFuncionalidade,
            string descricao,
            bool ativado)
        {
            ProjetoId = projetoId;
            MenuId = menuId;
            FuncionalidadePaiId = funcionalidadePaiId;
            CodigoFuncionalidade = codigoFuncionalidade;
            Descricao = descricao;
            Ativado = ativado;
            Diagramas = new List<Diagrama>();
            Manuais = new List<Manual>();
        }

        public virtual Projeto Projeto { get; private set; }
        public Guid ProjetoId { get; private set; }
        public virtual Menu Menu { get; private set; }
        public Guid MenuId { get; private set; }
        public virtual Funcionalidade FuncionalidadePai { get; private set; }
        public Guid? FuncionalidadePaiId { get; private set; }
        public virtual CodigoFuncionalidade CodigoFuncionalidade { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativado { get; private set; }
        public virtual Sds Sds { get; set; }
        public virtual ICollection<Diagrama> Diagramas { get; set; }
        public virtual ICollection<Manual> Manuais { get; set; }

        public override bool EhValido()
        {
            RuleFor(c => c.Projeto.Id)
               .NotEmpty().WithMessage("O Projeto precisa ser fornecido");

            RuleFor(c => c.Menu.Id)
               .NotEmpty().WithMessage("O Menu precisa ser fornecido");


            RuleFor(c => c.Descricao)
               .NotEmpty().WithMessage("A Descrição precisa ser fornecida");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
