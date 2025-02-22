using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace Application
{
    public static class FluentValidationStartup
    {
        public static IServiceCollection AddApplicationValidation(this IServiceCollection services)
        {
            //Fluent validation settings

            //// After: Enabling auto-validation only
            services.AddFluentValidationAutoValidation();
            //// After: Enabling client validation only:
            services.AddFluentValidationClientsideAdapters();
            
            services.AddValidatorsFromAssembly(typeof(FluentValidationStartup).Assembly);
            //[ApiController] tag prevent default BadRequest return
            services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

            return services;
        }
    }
}
