﻿// <auto-generated />
using System;
using AL_VALHALLA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AL_VALHALLA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240702224522_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("AL_VALHALLA.Models.DestinoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("AL_VALHALLA.Models.ReservaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CI")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadPersonas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comprobante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DestinoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DestinoId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("AL_VALHALLA.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AL_VALHALLA.Models.ReservaModel", b =>
                {
                    b.HasOne("AL_VALHALLA.Models.DestinoModel", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");
                });
#pragma warning restore 612, 618
        }
    }
}
