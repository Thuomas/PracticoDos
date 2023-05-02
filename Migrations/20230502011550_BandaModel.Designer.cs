﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPDos.Data;

#nullable disable

namespace TPdos.Migrations
{
    [DbContext(typeof(ArtistaContext))]
    [Migration("20230502011550_BandaModel")]
    partial class BandaModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("TPdos.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("TPdos.Models.Banda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fundation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Banda");
                });

            modelBuilder.Entity("TPdos.Models.Banda", b =>
                {
                    b.HasOne("TPdos.Models.Artista", "Artista")
                        .WithMany("Bandas")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("TPdos.Models.Artista", b =>
                {
                    b.Navigation("Bandas");
                });
#pragma warning restore 612, 618
        }
    }
}