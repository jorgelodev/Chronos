using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;


namespace Chronos.Business.Entities
{
    public class Projeto:Entity<Projeto>
    {
        protected Projeto()
        {

        }
        public Projeto(string nomeProjeto, string prefixo, bool ativado)
        {
            NomeProjeto = nomeProjeto;
            Prefixo = prefixo;
            Ativado = ativado;
            Menus = new List<Menu>();
            Funcionalidades = new List<Funcionalidade>();
        }

        public string NomeProjeto { get; private set; }
        public string Prefixo { get; private set; }
        public bool Ativado { get; private set; }
        public virtual ICollection<Menu> Menus { get; set; }       
        public virtual ICollection<Funcionalidade> Funcionalidades { get; set; }
        public override bool EhValido()
        {            
            RuleFor(c => c.NomeProjeto)
               .NotEmpty().WithMessage("O Nome do Projeto precisa ser fornecido");


            RuleFor(c => c.Prefixo)
               .NotEmpty().WithMessage("O Prefixo precisa ser fornecido");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}