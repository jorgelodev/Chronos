using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Chronos.API.ViewModels
{
    public class FuncionalidadeViewModel
    {
        public Guid Id { get; set; }
        public ProjetoViewModel Projeto { get; set; }
        public Guid ProjetoId { get; set; }
        public MenuViewModel Menu { get; set; }
        public Guid MenuId { get; set; }
        
    
        public FuncionalidadeViewModel FuncionalidadePai { get; set; }
        public Guid? FuncionalidadePaiId { get; private set; }
        public CodigoFuncionalidadeViewModel CodigoFuncionalidade { get; set; }
        public string Descricao { get;set; }
        public bool Ativado { get; set; }
       
        public SdsViewModel Sds { get; set; }
        public IEnumerable<DiagramaViewModel> Diagramas { get; set; }
        public IEnumerable<ManualViewModel> Manuais { get; set; }
        
        public DateTime DataCadastro { get; private set; }
      
        public ValidationResult ValidationResult { get; set; }
    }
}
