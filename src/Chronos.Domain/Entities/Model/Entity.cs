using FluentValidation;
using FluentValidation.Results;
using System;

namespace Chronos.Business.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        public Guid Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        protected Entity()
        {            
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }

        public ValidationResult ValidationResult { get; set; }
        public abstract bool EhValido();
        
    }
}
