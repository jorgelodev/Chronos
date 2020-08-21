using System.ComponentModel.DataAnnotations;

namespace Chronos.API.ViewModels
{
    public class CodigoFuncionalidadeViewModel
    {        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(3, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string PrefixoProjeto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(3, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string PrefixoMenu { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]        
        public int SequencialNumerico { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string IdentificacaoCompleta { get; set; }      
    }
}
