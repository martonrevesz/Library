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

namespace SimbaProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<LibraryContext>(options =>
                options.UseNpgsql("User ID=vzaxfwdvflvbnr;Password=e00f01d23416e40becbcee64e71876fd428e252d923a5eeabc8024235b316209;Host=ec2-54-217-245-9.eu-west-1.compute.amazonaws.com;Port=5432;Database=d6gb44hc3ocbvt;Pooling=true;sslmode=Require;Trust Server Certificate=true;Timeout=1000;"));
            services.AddScoped<LibraryRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
