using DevBoost.DependecyInjection.Domain.Interfaces.Services;
using DevBoost.DependecyInjection.DomainServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Devboost.DependencyInjection.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton(config);
            services.AddScoped<IAtividades, Atividades>();
            services.AddScoped<IEsportistas, Esportistas>();

            return services;
        }
    }
}
