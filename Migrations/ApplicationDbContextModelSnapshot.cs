﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.Modelo;

#nullable disable

namespace Proyecto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto.Modelo.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("Proyecto.Modelo.CoordinadorDeRevision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoordinadorDeRevisiones");
                });

            modelBuilder.Entity("Proyecto.Modelo.Gestor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gestores");
                });

            modelBuilder.Entity("Proyecto.Modelo.Informe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoordinadorDeRevisionId")
                        .HasColumnType("int");

                    b.Property<string>("Detalles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcesoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoordinadorDeRevisionId");

                    b.HasIndex("ProcesoId");

                    b.ToTable("Informes");
                });

            modelBuilder.Entity("Proyecto.Modelo.Proceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GestorId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecretariaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GestorId");

                    b.HasIndex("SecretariaId");

                    b.ToTable("Procesos");
                });

            modelBuilder.Entity("Proyecto.Modelo.Propuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RevisorPropuestaId")
                        .HasColumnType("int");

                    b.Property<int?>("SecretariaId")
                        .HasColumnType("int");

                    b.Property<string>("Título")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("RevisorPropuestaId");

                    b.HasIndex("SecretariaId");

                    b.ToTable("Propuestas");
                });

            modelBuilder.Entity("Proyecto.Modelo.RevisorPropuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RevisorPropuestas");
                });

            modelBuilder.Entity("Proyecto.Modelo.Secretaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Secretarias");
                });

            modelBuilder.Entity("Proyecto.Modelo.Informe", b =>
                {
                    b.HasOne("Proyecto.Modelo.CoordinadorDeRevision", "CoordinadorDeRevisiones")
                        .WithMany("Informes")
                        .HasForeignKey("CoordinadorDeRevisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Modelo.Proceso", "Procesos")
                        .WithMany("Informes")
                        .HasForeignKey("ProcesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoordinadorDeRevisiones");

                    b.Navigation("Procesos");
                });

            modelBuilder.Entity("Proyecto.Modelo.Proceso", b =>
                {
                    b.HasOne("Proyecto.Modelo.Gestor", "Gestores")
                        .WithMany("Procesos")
                        .HasForeignKey("GestorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proyecto.Modelo.Secretaria", "Secretarias")
                        .WithMany("ProcesosRegistrados")
                        .HasForeignKey("SecretariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gestores");

                    b.Navigation("Secretarias");
                });

            modelBuilder.Entity("Proyecto.Modelo.Propuesta", b =>
                {
                    b.HasOne("Proyecto.Modelo.Alumno", "Alumno")
                        .WithMany("PropuestasACorregir")
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Proyecto.Modelo.RevisorPropuesta", "RevisorPropuestas")
                        .WithMany("PropuestasRevisadas")
                        .HasForeignKey("RevisorPropuestaId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Proyecto.Modelo.Secretaria", "Secretaria")
                        .WithMany("PropuestasCargadas")
                        .HasForeignKey("SecretariaId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Alumno");

                    b.Navigation("RevisorPropuestas");

                    b.Navigation("Secretaria");
                });

            modelBuilder.Entity("Proyecto.Modelo.Alumno", b =>
                {
                    b.Navigation("PropuestasACorregir");
                });

            modelBuilder.Entity("Proyecto.Modelo.CoordinadorDeRevision", b =>
                {
                    b.Navigation("Informes");
                });

            modelBuilder.Entity("Proyecto.Modelo.Gestor", b =>
                {
                    b.Navigation("Procesos");
                });

            modelBuilder.Entity("Proyecto.Modelo.Proceso", b =>
                {
                    b.Navigation("Informes");
                });

            modelBuilder.Entity("Proyecto.Modelo.RevisorPropuesta", b =>
                {
                    b.Navigation("PropuestasRevisadas");
                });

            modelBuilder.Entity("Proyecto.Modelo.Secretaria", b =>
                {
                    b.Navigation("ProcesosRegistrados");

                    b.Navigation("PropuestasCargadas");
                });
#pragma warning restore 612, 618
        }
    }
}
