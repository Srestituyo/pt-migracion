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

namespace pt_migracion.webapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            using (var client = new ApplicationDbContext())
            {
                client.Database.EnsureCreated();
                 
                if (!client.Estados.Any())
                {
                    var aEstado = new Estados()
                    {
                        Estado = "Abiertas",
                        TimeStamp = DateTime.UtcNow
                    };

                    client.Estados.Add(aEstado);

                    var aEstado1 = new Estados()
                    {
                        Estado = "Aprobadas",
                        TimeStamp = DateTime.UtcNow
                    };

                    client.Estados.Add(aEstado1);

                    var aEstado2 = new Estados()
                    {
                            Estado = "Canceladas",
                            TimeStamp = DateTime.UtcNow
                    };

                    client.Estados.Add(aEstado2); 
                    client.SaveChanges();
                } 
            }
        }

        public IConfiguration Configuration { get; }
         

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        { 
            IServiceCollection serviceCollection = services.AddEntityFrameworkSqlite().AddDbContext<ApplicationDbContext>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "pt_migracion.webapi", Version = "v1" });
            });

            services.AddMemoryCache();
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
