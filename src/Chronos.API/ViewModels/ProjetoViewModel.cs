using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chronos.API.ViewModels
{
    public class ProjetoViewModel
    {
       
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string NomeProjeto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Prefixo { get; set; }

        public bool Ativado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public IEnumerable<MenuViewModel> Menus { get; set; }
          
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
