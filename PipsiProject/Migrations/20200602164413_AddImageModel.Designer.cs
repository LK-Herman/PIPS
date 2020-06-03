﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PipsiProject.Models;

namespace PipsiProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200602164413_AddImageModel")]
    partial class AddImageModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PipsiProject.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BigImage");

                    b.Property<int>("Cena");

                    b.Property<string>("Klasa");

                    b.Property<string>("Kolor");

                    b.Property<string>("Marka")
                        .IsRequired();

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<string>("Paliwo");

                    b.Property<float>("PojSilnika");

                    b.Property<double>("Przebieg");

                    b.Property<DateTime>("RokProd");

                    b.Property<byte[]>("SmImage");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("PipsiProject.Models.ImageModel", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
