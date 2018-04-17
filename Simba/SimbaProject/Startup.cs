using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
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
            //hahaha fatastic changes
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<LibraryContext>(options =>
                options.UseNpgsql("User ID = oeqbvhkyychhdo; Password = 0e3ff9c02d52a0e6d6415dfdab776db3e740101f382ec8d09cd2ed5042a24275; Host = ec2-54-217-245-9.eu-west-1.compute.amazonaws.com; Port = 5432; Database = d71d9o4jftdbk0; Pooling = true; sslmode = Require; Trust Server Certificate = true; Timeout = 1000;"));
            services.AddScoped<LibraryRepository>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
