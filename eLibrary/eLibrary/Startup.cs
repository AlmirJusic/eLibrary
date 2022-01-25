


using eLibrary;
using eLibrary.Database;
using eLibrary.Model.Requests.Drzava;
using eLibrary.Model.Requests.Grad;
using eLibrary.Model.Requests.Zanr;
using eLibrary.Model.Requests.Uloga;
using eLibrary.Services.Interfaces;
using eLibrary.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLibrary.Database.Models;
using eLibrary.Model.Requests.Pisac;
using eLibrary.Model.Requests.Knjiga;
using Microsoft.AspNetCore.Authentication;
using eLibrary.Security;
using eLibrary.Model.Requests.KorisnikKnjigaKomentar;
using eLibrary.Model.Requests.KorisnikKnjigaOcjena;
using eLibrary.Model.Requests.NacinPlacanja;
using eLibrary.Model.Requests.Placanje;
using eLibrary.Model.Requests.KupovinaKnjige;
using eLibrary.Model.Requests.PrijedlogKnjige;

namespace eLibrary
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

            services.AddControllers();

            services.AddDbContext<eLibraryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("eLibrary")));
            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eLibrary", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });

            services.AddAutoMapper(typeof(Startup));



            services.AddScoped<ICRUDService<eLibrary.Model.Drzava, DrzavaSearchRequest, DrzavaInsertRequest, DrzavaInsertRequest>, DrzavaService>();
            services.AddScoped<ICRUDService<eLibrary.Model.Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest>, GradService>();
            services.AddScoped<ICRUDService<eLibrary.Model.Zanr, ZanrSearchRequest, ZanrInsertRequest, ZanrInsertRequest>, ZanrService>();
            services.AddScoped<ICRUDService<eLibrary.Model.Uloga, UlogaSearchRequest, UlogaInsertRequest, UlogaInsertRequest>, UlogaService>();
            services.AddScoped<ICRUDService<eLibrary.Model.Spol, eLibrary.Model.Spol, eLibrary.Model.Spol, eLibrary.Model.Spol>, BaseCRUDService<eLibrary.Model.Spol, eLibrary.Model.Spol, eLibrary.Database.Models.Spol, eLibrary.Model.Spol, eLibrary.Model.Spol>>();
            services.AddScoped<ICRUDService<eLibrary.Model.Pisac, PisacSearchRequest, PisacInsertRequest, PisacInsertRequest>, PisacService>();
            services.AddScoped<ICRUDService<eLibrary.Model.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest, KnjigaInsertRequest>, KnjigaService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<ICRUDService<eLibrary.Model.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarRequest, KorisnikKnjigaKomentarRequest, KorisnikKnjigaKomentarRequest>, BaseCRUDService<eLibrary.Model.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarRequest, eLibrary.Database.Models.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarRequest, KorisnikKnjigaKomentarRequest>>();
            services.AddScoped<ICRUDService<eLibrary.Model.KorisnikKnjigaOcjena, eLibrary.Model.KorisnikKnjigaOcjena, KorisnikKnjigaOcjenaRequest, KorisnikKnjigaOcjenaRequest>, BaseCRUDService<eLibrary.Model.KorisnikKnjigaOcjena, eLibrary.Model.KorisnikKnjigaOcjena, eLibrary.Database.Models.KorisnikKnjigaOcjena, KorisnikKnjigaOcjenaRequest, KorisnikKnjigaOcjenaRequest>>();
            services.AddScoped<ICRUDService<eLibrary.Model.NacinPlacanja, NacinPlacanjaSearchRequest, NacinPlacanjaInsertRequest, NacinPlacanjaInsertRequest>, NacinPlacanjaService>();
            services.AddScoped<ICRUDService<eLibrary.Model.Placanje, PlacanjeSearchRequest,PlacanjeInsertRequest, PlacanjeInsertRequest>, PlacanjeService>();
            services.AddScoped<ICRUDService<eLibrary.Model.KupovinaKnjige, KupovinaKnjigeSearchRequest, KupovinaKnjigeInsertRequest, KupovinaKnjigeInsertRequest>, KupovinaKnjigeService>();
            services.AddScoped<ICRUDService<eLibrary.Model.PrijedlogKnjige, PrijedlogKnjigeSearchRequest, PrijedlogKnjigeInsertRequest, PrijedlogKnjigeInsertRequest>, PrijedlogKnjigeService>();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "eLibrary v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
