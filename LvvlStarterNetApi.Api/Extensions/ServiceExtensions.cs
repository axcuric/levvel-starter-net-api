using LvvlStarterNetApi.Core.Services;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using LvvlStarterNetApi.SharedKernel.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LvvlStarterNetApi.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureExtensionServices(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
            services.Configure<IISOptions>(options =>
            {

            });
            services.AddScoped<ILoggerService, LoggerService>();
            services.AddScoped<IExampleService, ExampleService>();
        }
    }

}
