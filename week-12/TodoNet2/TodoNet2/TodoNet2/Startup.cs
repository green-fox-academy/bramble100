using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TodoNet2.Entities;
using Microsoft.EntityFrameworkCore;
using TodoNet2.Repositories;
using TodoNet2.Interfaces;

namespace TodoNet2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionstring 
                = Environment.GetEnvironmentVariable("Todo2ConnectionString", 
                EnvironmentVariableTarget.User); //netcore 1.1-be nem lehetett enviroment usert beirni
            services.AddDbContext<TodoContext>(
                options => options.UseNpgsql(connectionstring));
            services.AddMvc();
            services.AddScoped<ITodoRepository, TodoRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env /*,ILoggerFactory loggerFactory*/)
        {
            //Net 1.1:

            //loggerFactory.AddConsole();

            app.UseMvcWithDefaultRoute();           

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
