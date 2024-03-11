
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Mapping;

namespace WebApi.DependencyInjection
{
    public static class DependencyInjectionHandler
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddRepositoriesDependencyInjection();

            services.AddAutoMapper(typeof(CooperadoToDTOMapping));
            services.AddAutoMapper(typeof(UnidadeConsumidoraToDTOMapping));
            services.AddAutoMapper(typeof(EnderecoToDTOMapping));
        }
    }
}
