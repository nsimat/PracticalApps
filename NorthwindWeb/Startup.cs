using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using NorthwindContextLib;

namespace NorthwindWeb
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        private IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddDbContext<Northwind>(options => {
                options.UseSqlServer(Configuration["ConnectionStrings:NorthwindDB"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRouting();
            app.Use(async (HttpContext context, Func<Task> next) => 
            {
                var rep = context.GetEndpoint() as RouteEndpoint;
                if(rep != null)
                {
                    Console.WriteLine($"Endpoint name: {rep.DisplayName}");
                    Console.WriteLine($"Endpoint route pattern: {rep.RoutePattern.RawText}");
                }

                if(context.Request.Path == "/bonjour")
                {
                    await context.Response.WriteAsync("Bonjour Monde!");
                    return;
                }
                await next();
            });
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapGet("/hello", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
