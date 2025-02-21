using Application;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using WebAPI;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<ModelDbContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddControllers(options =>
        {
            // Adding validate model filter
            options.Filters.Add<ValidateModelAttribute>();
        });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.RegisterMapsterConfigure();
        builder.Services.AddLogging();
        // local dI
        builder.Services.AddDependencyInjection();
        builder.Services.AddDependencyInjectionInfrastructure();
        // handle exceptions
        builder.Services.RegisterExceptionConfiguration();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.UseExceptionHandler(_ => { });

        app.Run();
    }
}