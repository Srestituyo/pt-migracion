using System;
using Microsoft.EntityFrameworkCore; 
using pt_migracion.data.Entity;

namespace pt_migracion.data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Equipo> Equipo { get; set; }

        public DbSet<Estados> Estados { get; set; }

        public DbSet<Persona> Persona { get; set; }

        public DbSet<Solicitud> Solicitud { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        } 

        protected override void OnModelCreating(ModelBuilder theModelBuilder)
        {
            theModelBuilder.Entity<Persona>(aEntity =>
            {
                aEntity.HasKey(e => e.Id);
                aEntity.Property(e => e.Id).HasColumnType("uniqueidentifier").IsRequired();
                aEntity.Property(e => e.Nombre).HasMaxLength(45).HasColumnType("nvarchar(45)").IsRequired();
                aEntity.Property(e => e.Apellido).HasMaxLength(45).HasColumnType("nvarchar(45)").IsRequired();
                aEntity.Property(e => e.FechaNacimiento).HasColumnType("nvarchar(45)").IsRequired();
                aEntity.Property(e => e.Pasaporte).HasMaxLength(9).IsRequired();
                aEntity.Property(e => e.Direccion).HasColumnType("nvarchar(max)").IsRequired();
                aEntity.Property(e => e.Sexo);
                aEntity.Property(e => e.FotoPath).HasColumnType("nvarchar(max)");
                aEntity.Property(e => e.TimeStamp).HasColumnType("datetime2").IsRequired();

                aEntity.HasMany(e => e.Equipos).WithOne(e => e.Persona).HasForeignKey(e => e.PersonaId);
            });

            theModelBuilder.Entity<Solicitud>(aEntity =>
            {
                aEntity.HasKey(e => e.Id);
                aEntity.Property(e => e.Id).HasColumnType("uniqueidentifier").IsRequired();
                aEntity.Property(e => e.NombreEstado).HasColumnType("nvarchar(45)").IsRequired();
                aEntity.Property(e => e.FechaDeCreacion).HasColumnType("datetime2").IsRequired();
                aEntity.Property(e => e.TimeStamp).HasColumnType("datetime2").IsRequired();

                aEntity.HasOne(e => e.Equipo).WithOne(e => e.Solicitud);
            });

            theModelBuilder.Entity<Estados>(aEntity =>
            {
                aEntity.HasKey(e => e.Id);
                aEntity.Property(e => e.Id).HasColumnType("uniqueidentifier").IsRequired();
                aEntity.Property(e => e.Estado).HasColumnType("nvarchar(45)").IsRequired();
                aEntity.Property(e => e.TimeStamp).HasColumnType("datetime2").IsRequired();
            });

            theModelBuilder.Entity<Equipo>(aEntity =>
            {
                aEntity.HasKey(e => e.Id);
                aEntity.Property(e => e.Id).HasColumnType("uniqueidentifier").IsRequired();
                aEntity.HasOne(e => e.Solicitud).WithOne(e => e.Equipo);
                aEntity.HasOne(e => e.Persona).WithMany(e => e.Equipos);
                aEntity.HasOne(e => e.Estados).WithOne(e => e.Equipo);
                aEntity.Property(e => e.TimeStamp).HasColumnType("datetime2").IsRequired();
            });


        }
    }
}
