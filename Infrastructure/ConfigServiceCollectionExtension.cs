using Domain.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
{
    public static class ConfigServiceCollectionExtension
    {
        public static IServiceCollection AddDependencyInjectionInfrastructure(this IServiceCollection services) {
            services.AddTransient<IModelRepository, ModelRepository>();
            return services;
        }
    }
}
