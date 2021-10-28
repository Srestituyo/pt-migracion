using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using pt_migracion.data;
using pt_migracion.data.Entity;
using System;
using pt_migracion.repository.Interface;
using pt_migracion.repository;
using pt_migracion.service.Interfaces;
using pt_migracion.service;
using Microsoft.EntityFrameworkCore;

namespace pt_migracion.webapi
{
    public class Startup
    {

        private string DbPath { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }

        public IConfiguration Configuration { get; }
         

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("AppConnectionString")
                    , b => b.MigrationsAssembly("pt-migracion.webapi")));

            services.AddScoped(typeof(IPersonaRepository), typeof(PersonaRepository));
            services.AddScoped(typeof(IEquipoRepository), typeof(EquipoRepository));
            services.AddScoped(typeof(ISolicitudRepository), typeof(SolicitudRepository));
            services.AddScoped(typeof(IEstadosRepository), typeof(EstadosRepository));

            services.AddTransient<IPersonaService, PersonaService>();
            services.AddTransient<IEquipoService, EquipoService>();
            services.AddTransient<ISolicitudService, SolicitudService>();
            services.AddTransient<IEstadoService, EstadoService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "pt_migracion.webapi", Version = "v1" });
            });

            services.AddMemoryCache();

            //using (var client = services.Db)
            //{
            //    client.Database.EnsureCreated();

            //    try
            //    {
            //        if (!client.Estados.Any())
            //        {
            //            var aEstado = new Estados()
            //            {
            //                Estado = "Abiertas",
            //                TimeStamp = DateTime.UtcNow
            //            };

            //            client.Estados.Add(aEstado);

            //            var aEstado1 = new Estados()
            //            {
            //                Estado = "Aprobadas",
            //                TimeStamp = DateTime.UtcNow
            //            };

            //            client.Estados.Add(aEstado1);

            //            var aEstado2 = new Estados()
            //            {
            //                Estado = "Canceladas",
            //                TimeStamp = DateTime.UtcNow
            //            };

            //            client.Estados.Add(aEstado2);
            //            client.SaveChanges();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Please run migration");
            //    }

            //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "pt_migracion.webapi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
