using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chronos.API.ViewModels
{
    public class FuncionalidadeViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [ScaffoldColumn(false)]
        public ProjetoViewModel Projeto { get; set; }
        public Guid ProjetoId { get; set; }

        [ScaffoldColumn(false)]
        public MenuViewModel Menu { get; set; }
        
        public Guid MenuId { get; set; }
        
        [ScaffoldColumn(false)]
        public FuncionalidadeViewModel FuncionalidadePai { get; set; }
        public Guid? FuncionalidadePaiId { get; set; }
        public CodigoFuncionalidadeViewModel CodigoFuncionalidade { get; set; }
        public string Descricao { get;set; }
        public bool Ativado { get; set; }
       
        public SdsViewModel Sds { get; set; }
        public IEnumerable<DiagramaViewModel> Diagramas { get; set; }
        public IEnumerable<ManualViewModel> Manuais { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }        
        public FluentValidation.Results.ValidationResult ValidationResult { get; set; }
    }
}
