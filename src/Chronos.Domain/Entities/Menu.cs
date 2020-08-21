using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Chronos.Business.Entities
{
    public class Menu:Entity<Menu>
    {
        protected Menu() { }
        public Menu(
            Guid projetoId, 
            string nomeMenu,
            string prefixo,
            bool ativado)
        {
            ProjetoId = projetoId;            
            NomeMenu = nomeMenu;
            Prefixo = prefixo;
            Ativado = ativado;
            Funcionalidades = new List<Funcionalidade>();
        }
        public Guid ProjetoId { get; private set; }
        public string NomeMenu { get; private set; }
        public string Prefixo { get; private set; }
        public bool  Ativado{ get; private set; }
        public virtual ICollection<Funcionalidade> Funcionalidades { get; set; }
        public virtual Projeto Projeto{ get; set; }
        public override bool EhValido()
        {
            RuleFor(c => c.ProjetoId)
               .NotEmpty().WithMessage("O Projeto precisa ser fornecido");


            RuleFor(c => c.NomeMenu)
               .NotEmpty().WithMessage("O Nome do menu precisa ser fornecido");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}