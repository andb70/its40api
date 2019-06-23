using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using its40api.DataAccess;
using its40api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace its40api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("all", builder => {
                    builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            string ConnectionStringInflux = "https://192.168.137.1:8086";
            string ConnectionStringMongo = "mongodb+srv://itsadmin:_its_40_admin@its40-umlny.mongodb.net/test?retryWrites=true&w=majority";
            services.AddScoped<IDataAccess<Zone>, ZoneDataAccess>((cs) => new ZoneDataAccess(ConnectionStringInflux));
            services.AddScoped<IDataAccess<ZonePerformance>, ZonePerformanceDataAccess>((cs) => new ZonePerformanceDataAccess(ConnectionStringInflux));
            services.AddScoped<IDataAccess<CartPath>, CartPathDataAccess>((cs) => new CartPathDataAccess(ConnectionStringInflux));
            services.AddScoped<IDataAccess<Receipt>, ReceiptDataAccess>((cs) => new ReceiptDataAccess(ConnectionStringInflux));


             //services.AddScoped<IDataAccess<Cart>, CartDataAccess>((cs) => new CartDataAccess(ConnectionStringInflux));
            services.AddScoped<IDataAccess<Cart>, MongoDataAccess>((cs) => new MongoDataAccess(ConnectionStringMongo));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use(async (ctx, next) =>
            {
                ctx.Response.Headers.Add("Content-Security-Policy",
                                         "default-src 'self' style-src 'self' 'unsafe-inline'; report-uri /cspreport");
                await next();
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseCors("all");
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            }); ;
        }
    }
}
