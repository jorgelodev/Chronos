using System;
using System.ComponentModel.DataAnnotations;

namespace Chronos.API.ViewModels
{
    public abstract class DocumentoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string NomeArquivo { get; set; }
        public int StatusArquivo { get; set; }

        public Guid FuncionalidadeId { get; set; }
        public FuncionalidadeViewModel Funcionalidade { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; private set; }

        [ScaffoldColumn(false)]
        public ValidationResult ValidationResult { get; set; }
    }
}