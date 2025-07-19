using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace dopNP.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services)
        {
            // Add services to the container.

            services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            // Add API-specific configurations 

            // Add other necessary services, e.g., Swagger, CORS, etc.
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options =>
            {
                string buildVersion = typeof(DependencyInjection).Assembly.GetName().Version?.ToString() ?? "default";
                string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "dopNP - API",
                    Version = $"v{buildVersion} - {environmentName}",
                    Description = "API dopNetPix é um projeto voltado à simulação e integração de transações via PIX."
                });
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    policy => policy.WithOrigins("http://")
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              .AllowCredentials());
            });

            return services;
        }
        public static WebApplication UseEnvironment(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger(
                options =>
                {
                    options.RouteTemplate = "swagger/{documentName}/swagger.json"; // Customize the route template if needed
                });

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "dopNP API V1");
                    c.RoutePrefix = "swagger"; // Set the Swagger UI route prefix
                });
            }

            return app;
        }
    }
}
