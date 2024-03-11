using WebApi.Interfaces;
using WebApi.Repositories;

namespace WebApi.DependencyInjection
{
    public static class RepositoriesDependencyInjection
    {
        public static void AddRepositoriesDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICooperadoRepository, CooperadoRepository>();
            services.AddScoped<IUnidadeConsumidoraRepository, UnidadeConsumidoraRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        }
    }
}
