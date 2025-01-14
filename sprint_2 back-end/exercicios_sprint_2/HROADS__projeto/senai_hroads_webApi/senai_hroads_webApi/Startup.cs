using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace senai_hroads_webApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()

                  .AddNewtonsoftJson(options =>
                  {
                      // Ignora os loopings nas consultas
                      options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                      // Ignora valores nulos ao fazer jun��es nas consultas
                      options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                  });

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Hroads.webApi",
                    Version = "v1",
                    Description = "Essa API foi feita com objetivo de aprimorar meu " +
                    "conhecimentos no desenvolvimento das mesmas, utilizando Entity Framework, DbFirst  ",
                    Contact = new OpenApiContact
                    {
                        Name = "Brenda Larissa",
                        Email = string.Empty,

                    }
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            }
                );

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })

                .AddJwtBearer("JwtBearer", options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("hroads-chave-secreta-autenticacao")),
                        ClockSkew = TimeSpan.FromMinutes(10),
                        ValidIssuer = "Hroads.webApi",
                        ValidAudience = "Hroads.webApi"
                    };
                });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            app.UseSwaggerUI(c =>
             {
                 c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hroads.webApi");
                 c.RoutePrefix = string.Empty;
             });

            app.UseAuthentication();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        }
    }
}
