
using Chronos.Business.Interfaces.Repositories;
using Chronos.Business.Interfaces.Services;
using Chronos.Business.Services;
using Chronos.Infra.Data.Context;
using Chronos.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Chronos.Services.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DBContext>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IFuncionalidadeRepository, FuncionalidadeRepository>();

            services.AddScoped<IProjetoService, ProjetoService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IFuncionalidadeService, FuncionalidadeService>();
            
            
            //services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
