using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SimbaProject.ViewModels;
using SimbaProject.Entities;
using Microsoft.EntityFrameworkCore;
using SimbaProject.Repositories;
using Microsoft.Extensions.Configuration;

namespace SimbaProject
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<LibraryContext>(options => options.UseNpgsql("User ID=eicsfmzbzdxuhk;Password=9060a958d187e72d37122f5bf1b529b027d9d50e3934a42836a6fcd5d464d7fa;Host=ec2-54-217-214-201.eu-west-1.compute.amazonaws.com;Port=5432;Database=d95mk0ksvuoe8a;Pooling=true;sslmode=Require;Trust Server Certificate=true;Timeout=1000;"));
            services.AddScoped<LibraryRepository>();

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseStaticFiles();
        }
    }
}
