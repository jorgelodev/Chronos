using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Chronos.API.ViewModels
{
    public class MenuViewModel
    {     
        public Guid Id { get; set; }        
        public Guid ProjetoId { get; set; }

        public string NomeMenu { get; set; }
                
        public string Prefixo { get; set; }
        public bool Ativado { get; set; }

        public DateTime DataCadastro { get; private set; }
        public IEnumerable<FuncionalidadeViewModel> Funcionalidades { get; set; }        
        public ProjetoViewModel Projeto { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
