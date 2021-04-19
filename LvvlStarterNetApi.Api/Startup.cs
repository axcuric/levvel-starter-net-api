using LvvlStarterNetApi.Api.Extensions;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LvvlStarterNetApi.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDataBaseContext(_configuration);
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.ConfigureLoggerService();
            services.ConfigureScopedServices();
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));

            services.ConfigureSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerService logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LvvlStarterNetApi.Api v1"));
            }
            else
            {
                //adds the Strict - Transport - Security header.
                app.UseHsts();
            }

            app.ConfigureExceptionHandler(logger);

            app.UseHttpsRedirection();

            //Enables using static files for the request. If
            //we don’t set a path to the static files directory, it will use a wwwroot
            //folder in our project by default.
            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            // Thiswill forward proxy headers to the current request.
            // For more informaiton: https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/proxy-load-balancer?view=aspnetcore-5.0
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}