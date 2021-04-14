﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VivazAPI.Data;

namespace VivazAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210414190249_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("VivazAPI.Models.ActivityType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WarrantyInYears")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ActivityTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07d418e3-4bd0-4d1c-a185-18d3983bded0"),
                            Description = "Instalação de equipamentos industrializados, como aquecedores, motobombas, filtros e interfones.",
                            WarrantyInYears = 1
                        },
                        new
                        {
                            Id = new Guid("0a7fc9a1-a55e-4ab1-b0ac-834d56dc518a"),
                            Description = "Borrachas, escovas, articulações, fechos e roldanas de esquadrias de alumínio ou PVC.",
                            WarrantyInYears = 2
                        },
                        new
                        {
                            Id = new Guid("3afc886e-06e7-4e60-b063-0597bddb8fa3"),
                            Description = "Fundações, estruturas principais e periféricas, contenções e arrimos, envolvendo segurança e estabilidade.",
                            WarrantyInYears = 5
                        });
                });

            modelBuilder.Entity("VivazAPI.Models.AddressState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AddressStates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fedc4169-1386-4fdb-adaf-b7f9a027fa79"),
                            Name = "São Paulo",
                            Uf = "SP"
                        },
                        new
                        {
                            Id = new Guid("bd1b5d86-2df8-43b6-a566-61c91d1fe1a8"),
                            Name = "Rio de Janeiro",
                            Uf = "RJ"
                        },
                        new
                        {
                            Id = new Guid("00e4d596-468e-4c4d-81db-ee79d55c4a40"),
                            Name = "Recife",
                            Uf = "RE"
                        });
                });

            modelBuilder.Entity("VivazAPI.Models.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("313c8631-8add-462f-a464-060f9d03fd03"),
                            Title = "Cyrela"
                        },
                        new
                        {
                            Id = new Guid("ee629e24-cc13-4cc3-9601-3ca3561d6255"),
                            Title = "Living"
                        },
                        new
                        {
                            Id = new Guid("642403e5-93c5-498b-9802-1ba37feebee7"),
                            Title = "Vivaz"
                        });
                });

            modelBuilder.Entity("VivazAPI.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4c2eed6-b60b-43b0-a643-03fbff474128"),
                            Email = "admin_user@mail.com",
                            Password = "admin123456",
                            Role = "admin"
                        },
                        new
                        {
                            Id = new Guid("ff99ed43-ded8-4c7a-9370-32c5b295e28d"),
                            Email = "employee_user@mail.com",
                            Password = "employee123456",
                            Role = "employee"
                        },
                        new
                        {
                            Id = new Guid("6552bba8-ee49-4d6c-b3fd-f089578f126f"),
                            Email = "customer_user@mail.com",
                            Password = "customer123456",
                            Role = "customer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
