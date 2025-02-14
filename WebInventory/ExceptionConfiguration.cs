using WebAPI.Exceptions;

namespace WebAPI
{
    public static class ExceptionConfiguration
    {
        public static void RegisterExceptionConfiguration(this IServiceCollection services) {
            services.AddExceptionHandler<BadRequestExceptionHandler>();
            services.AddExceptionHandler<NotFoundExceptionHandler>();
            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails();
        }
    }
}
