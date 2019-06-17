using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using its40api.DataAccess;
using its40api.Models;
using Microsoft.AspNetCore.Builder;
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            string ConnectionString = "192.168.101.27:8086";
            services.AddScoped<IDataAccess<Cart>, CartDataAccess>((cs) => new CartDataAccess(ConnectionString));
            services.AddScoped<IDataAccess<CartPath>, CartPathDataAccess>((cs) => new CartPathDataAccess(ConnectionString));
            services.AddScoped<IDataAccess<Receipt>, ReceiptDataAccess>((cs) => new ReceiptDataAccess(ConnectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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
            app.UseMvc();
        }
    }
}
