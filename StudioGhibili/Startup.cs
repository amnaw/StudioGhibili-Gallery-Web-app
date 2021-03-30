using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudioGhibili.Models;
using StudioGhibili.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using StudioGhibili.Controllers;

namespace StudioGhibili
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // ***** This method gets called by the HOST
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //    ******** ADD STUFF **********
            services.AddRazorPages();
            // my Services
            services.AddTransient<JsonCharacterService>();
            // my controllers
            services.AddControllers();
            // my Blazors
            services.AddServerSideBlazor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
            else
            {
                    app.UseExceptionHandler("/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //    ******** USE STUFF **********
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapBlazorHub();


                //************************ OUR FIRST API ********************************************
                //endpoints.MapGet("/characters", (context) =>
                //{
                //    var characters = app.ApplicationServices.GetService<JsonCharacterService>().GetCharacters();
                //    var json = JsonSerializer.Serialize<IEnumerable<Character>>(characters);
                //    return context.Response.WriteAsync(json);
                //}
                //);
                //********************************************************************
               });
            }
        }
    }

