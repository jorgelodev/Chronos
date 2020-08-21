using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Chronos.API.ViewModels
{
    public class ProjetoViewModel
    {
        public Guid Id { get; set; }

        public string NomeProjeto { get; set; }

        public string Prefixo { get; set; }

        public bool Ativado { get; set; }

        public DateTime DataCadastro { get; private set; }

        public IEnumerable<MenuViewModel> Menus { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
