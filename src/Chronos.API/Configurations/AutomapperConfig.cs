using AutoMapper;
using Chronos.API.ViewModels;
using Chronos.Business.Entities;
using FluentValidation.Results;

namespace Chronos.API.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Projeto, ProjetoViewModel>().ReverseMap();
            CreateMap<Menu, MenuViewModel>().ReverseMap();
            CreateMap<Funcionalidade, FuncionalidadeViewModel>();
            CreateMap<CodigoFuncionalidade, CodigoFuncionalidadeViewModel>().ReverseMap();
            CreateMap<Sds, SdsViewModel>();
            CreateMap<Manual, ManualViewModel>();
            CreateMap<Diagrama, DiagramaViewModel>();

            
            //CreateMap<Produto, ProdutoViewModel>()
            //    .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}
