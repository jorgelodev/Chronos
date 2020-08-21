using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chronos.API.ViewModels
{
    public class MenuViewModel
    {
        [Key]
        public Guid Id { get; set; }        
        public Guid ProjetoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string NomeMenu { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Prefixo { get; set; }
        public bool Ativado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public IEnumerable<FuncionalidadeViewModel> Funcionalidades { get; set; }
        
        public ProjetoViewModel Projeto { get; set; }
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
