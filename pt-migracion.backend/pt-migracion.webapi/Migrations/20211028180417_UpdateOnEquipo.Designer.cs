﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pt_migracion.data;

namespace pt_migracion.webapi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211028180417_UpdateOnEquipo")]
    partial class UpdateOnEquipo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pt_migracion.data.Entity.Equipo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EstadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PersonaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SolicitudId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("PersonaId");

                    b.HasIndex("SolicitudId")
                        .IsUnique();

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Estados", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Persona", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Pasaporte")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Solicitud", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Equipo", b =>
                {
                    b.HasOne("pt_migracion.data.Entity.Estados", "Estados")
                        .WithMany("Equipo")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pt_migracion.data.Entity.Persona", "Persona")
                        .WithMany("Equipos")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pt_migracion.data.Entity.Solicitud", "Solicitud")
                        .WithOne("Equipo")
                        .HasForeignKey("pt_migracion.data.Entity.Equipo", "SolicitudId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estados");

                    b.Navigation("Persona");

                    b.Navigation("Solicitud");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Estados", b =>
                {
                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Persona", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("pt_migracion.data.Entity.Solicitud", b =>
                {
                    b.Navigation("Equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
