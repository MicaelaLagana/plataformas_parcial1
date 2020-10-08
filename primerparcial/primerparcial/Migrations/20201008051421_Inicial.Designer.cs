﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using primerparcial;

namespace primerparcial.Migrations
{
    [DbContext(typeof(ParcialDBContext))]
    [Migration("20201008051421_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("primerparcial.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2020, 10, 8, 5, 14, 20, 390, DateTimeKind.Utc).AddTicks(3452));

                    b.Property<int?>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("primerparcial.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("primerparcial.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<int>("Estimacion")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ResponsableId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ResponsableId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("primerparcial.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("primerparcial.Detalle", b =>
                {
                    b.HasOne("primerparcial.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId");

                    b.HasOne("primerparcial.Tarea", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId");
                });

            modelBuilder.Entity("primerparcial.Recurso", b =>
                {
                    b.HasOne("primerparcial.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("primerparcial.Tarea", b =>
                {
                    b.HasOne("primerparcial.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableId");
                });
#pragma warning restore 612, 618
        }
    }
}
