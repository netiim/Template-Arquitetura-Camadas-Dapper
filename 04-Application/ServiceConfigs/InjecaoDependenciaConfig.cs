using Insfraestrutura.Repositorios;
using Services.Services;

namespace Template_Arquitetura_Camadas_Dapper.ServiceConfigs
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection WireDependencyInjections(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<IExemploRepositorio, ExemploRepositorio>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IExemploService, ExemploService>();

            return services;
        }
    }
}
