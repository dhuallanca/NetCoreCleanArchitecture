using Application.Interfaces;
using Application.Services;

namespace WebAPI
{
    /// <summary>
    /// To separate the dependency injection from program file
    /// </summary>
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IService, Service>();
            return services;
        }
    }
}
