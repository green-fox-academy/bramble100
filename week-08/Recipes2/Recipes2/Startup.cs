using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Recipes2.Repositories;
using Recipes2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Recipes2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            var connectionString = @"Data Source = (localdb)\ProjectsV13;" +
                "Initial Catalog = master;" +
                "Integrated Security = True;" +
                "Connect Timeout = 30;" +
                "Encrypt = False;" +
                "TrustServerCertificate = True;" +
                "ApplicationIntent = ReadWrite;" +
                "MultiSubnetFailover = False";
            services.AddMvc();
            services.AddScoped<RecipeRepository>();
            services.AddScoped<CommentRepository>();
            services.AddDbContext<RecipeContext>(
                options => options.UseSqlServer(connectionString));
            services.AddDbContext<CommentContext>(
                options => options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });

        }
    }
}
