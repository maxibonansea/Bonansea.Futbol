using AutoMapper;
using Bonansea.Futbol.Application.Interface;
using Bonansea.Futbol.Application.Main;
using Bonansea.Futbol.Domain.Core;
using Bonansea.Futbol.Domain.Interface;
using Bonansea.Futbol.Infraestructure.Data;
using Bonansea.Futbol.Infraestructure.Interface;
using Bonansea.Futbol.Infraestructure.Repository;
using Bonansea.Futbol.Services.WebApi.Helpers;
using Bonansea.Futbol.Transversal.Common;
using Bonansea.Futbol.Transversal.Mapper;
using Bonansea.Futbol.Transversal.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Bonansea.Futbol.Services.WebApi
{
    public class Startup
    {
        readonly string myPolicy = "policyApiFutbol";
        private string _configurationRepository;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _configurationRepository = configuration.GetValue<string>("ConfigurationRepository").ToString();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));

            services.AddCors(options =>
                options.AddPolicy(myPolicy, builder => builder.AllowAnyOrigin()
                                                               .AllowAnyHeader()
                                                               .AllowAnyMethod()));

            //options.AddPolicy(myPolicy, builder => builder.WithOrigins(Configuration["Config:OriginCors"])
            //                                                .AllowAnyHeader()
            //                                                .AllowAnyMethod()));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => { options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver(); });


            //Autenticación
            var appSettingsSection = Configuration.GetSection("Config");
            services.Configure<AppSettings>(appSettingsSection);

            //Configuración con JWT Authentication
            var appSettings = appSettingsSection.Get<AppSettings>();

            //Inyección de Dependencias:
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<IConnetionFactory, ConnectionFactory>();
            services.AddScoped<IJugadorApplication, JugadorApplication>();
            services.AddScoped<IJugadorDomain, JugadorDomain>();
            if (_configurationRepository == "database")
                services.AddScoped<IJugadorRepository, JugadorRepository>();
            else
                services.AddScoped<IJugadorRepository, JugadorRepositoryDemo>();
            services.AddScoped<IUsuarioApplication, UsuarioApplication>();
            services.AddScoped<IUsuarioDomain, UsuarioDomain>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            //Variables de Autenticación
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var Issuer = appSettings.Issuer;
            var Audience = appSettings.Audience;

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var IdUsuario = int.Parse(context.Principal.Identity.Name);
                        return Task.CompletedTask;
                    },

                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = Issuer,
                    ValidateAudience = true,
                    ValidAudience = Audience,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Bonansea Fútbol App - WebAPI",
                    Description = "Proyecto de WebAPI",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Maximiliano Bonansea",
                        Email = "mbonansea@gmail.com",
                        Url = ""
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }

                });

                //Swagger Json y UI
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                //Autenticación en Swagger
                c.AddSecurityDefinition("Authorization", new ApiKeyScheme
                {
                    Description = "Authorization by API key.",
                    In = "header",
                    Type = "apiKey",
                    Name = "Authorization"
                });
                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { "Authorization", new string[0] }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            
            //Habilitar middleware para Swagger Generator como un Endpoint Json.
            app.UseSwagger();

            //Habilitar el Dashbord de Swagger.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Fútbol V1");
            });

            app.UseCors(myPolicy);
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
