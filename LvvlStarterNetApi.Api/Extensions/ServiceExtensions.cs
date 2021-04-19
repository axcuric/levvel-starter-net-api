﻿using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.Core.Services;
using LvvlStarterNetApi.Infrastructure;
using LvvlStarterNetApi.Infrastructure.Context;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using LvvlStarterNetApi.SharedKernel.SharedServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace LvvlStarterNetApi.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection service)
        {
            service.AddScoped<IRepositoryManager<User>, RepositoryManager<User>>();
            service.AddScoped<IUserService<User>, UserService>();
        }

        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
           services.AddScoped<ILoggerService, LoggerService>();

        public static void ConfigureSwagger(this IServiceCollection services) =>
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "LvvlStarterNetApi.Api", Version = "v1" });

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(filePath);
            });

        public static void ConfigureDataBaseContext(this IServiceCollection services) =>
            services.AddDbContext<CliDbExampleContext>(opt => opt.UseInMemoryDatabase("CliDataBaseInMemory"));
    }
}