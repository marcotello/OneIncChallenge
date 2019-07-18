using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PaymentsAPI.Data;
using PaymentsAPI.Repositories;
using PaymentsAPI.Services;

namespace PaymentsAPI
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

            // Adding In memory DB Context
            services.AddDbContext<PaymentsAPIContext>(context => { context.UseInMemoryDatabase("ZeitDB"); });

            // Adding Repositories to the IoC engine
            services.AddScoped<ITransactionRespository, TransactionRepository>();

            // Adding Services to the IoC engine
            services.AddScoped<ITransactionService, TransactionService>();

            // adding Auto Mapper
            services.AddAutoMapper();

            // adding CORS to allow request from other domains
            services.AddCors(o => o.AddPolicy("MyPolicyCors", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                })
            );
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Seeding the database with dummy data located at ZeitApi.Data.DatabaseSeeder.cs
                app.SeedDatabase();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            // Using CORS with the policy defined in ConfiguredServices method
            app.UseCors("MyPolicyCors");
            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
