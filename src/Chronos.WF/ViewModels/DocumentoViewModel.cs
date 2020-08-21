using FluentValidation.Results;
using System;

namespace Chronos.API.ViewModels
{
    public abstract class DocumentoViewModel
    {
       
        public Guid Id { get; set; }

        public string NomeArquivo { get; set; }
        public int StatusArquivo { get; set; }

        public Guid FuncionalidadeId { get; set; }
        public FuncionalidadeViewModel Funcionalidade { get; set; }
       
        public DateTime DataCadastro { get; private set; }

      
        public ValidationResult ValidationResult { get; set; }
    }
}