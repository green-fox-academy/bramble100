﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FoxAirlines;
using FoxAirlines.Entities;
using FoxAirlines.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FoxAirlines
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connectionString =
                @"Data Source = (localdb)\ProjectsV13;" +
                "Initial Catalog = FoxAirlines;" +
                "Integrated Security = True;" +
                "Connect Timeout = 30;" +
                "Encrypt = False;" +
                "TrustServerCertificate = True;" +
                "ApplicationIntent = ReadWrite;" +
                "MultiSubnetFailover = False";

            services.AddSingleton<Random>();
            services.AddScoped<FlightTicketRepository>();
            services.AddDbContext<FlightTicketContext>(options => options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}