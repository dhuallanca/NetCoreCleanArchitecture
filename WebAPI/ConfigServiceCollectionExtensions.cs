using Application.Interfaces;
using Application.Services;
using Infrastructure.Repository;

namespace WebAPI
{
    /// <summary>
    /// To separate the dependency injection from program file
    /// </summary>
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {

            services.AddTransient<IModelRepository, ModelRepository>();
            services.AddTransient<IService, Service>();
            return services;
        }
    }
}
