﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OraclBilanIshlash.Db;
using OraclBilanIshlash.Interfaces;
using OraclBilanIshlash.Services;

namespace OraclBilanIshlash
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
            services.AddEntityFrameworkOracle().AddDbContext<OracleDataContext>(options =>
            {
                options.UseOracle("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (COMMUNITY = TCP)(PROTOCOL = TCP)(HOST = 192.168.45.84)(PORT = 1522)))(CONNECT_DATA = (SID = avast))); User Id = genesis; Password=genesis;Pooling=true");
            });

            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IAuthService, AuthService>();
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
