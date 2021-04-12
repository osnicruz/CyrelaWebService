using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}        

        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ActiveType> ActiveTypes { get; set; }
        public DbSet<AddressState> AddressStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();
            // modelBuilder.HasPostgresExtension("uuid-ossp")
            //        .Entity<User>()
            //        .Property(e => e.Id)
            //        .HasDefaultValueSql("uuid_generate_v4()");

            modelBuilder.Entity<User>()
                .HasData(
                    new List<User>() {
                        new User {
                            Id       = Guid.NewGuid(),
                            Email    = "admin_user@mail.com",
                            Password = "admin123456",
                            Role     = "admin"
                        },
                        new User {
                            Id       = Guid.NewGuid(),
                            Email    = "employee_user@mail.com",
                            Password = "employee123456",
                            Role     = "employee"
                        },
                        new User {
                            Id       = Guid.NewGuid(),
                            Email    = "customer_user@mail.com",
                            Password = "customer123456",
                            Role     = "customer"
                        }
                    }
                );

            modelBuilder.Entity<Brand>()
                .HasData(
                    new List<Brand>() {
                        new Brand() {
                            Id    = Guid.NewGuid(),
                            Title = "Cyrela"
                        },
                        new Brand() {
                            Id    = Guid.NewGuid(),
                            Title = "Living"
                        },
                        new Brand() {
                            Id    = Guid.NewGuid(),
                            Title = "Vivaz"
                        }
                    }
                );

            modelBuilder.Entity<ActiveType>()
                .HasData(
                    new List<ActiveType>() {
                        new ActiveType() {
                            Id              = Guid.NewGuid(),
                            Description     = "Instalação de equipamentos industrializados, como aquecedores, motobombas, filtros e interfones.",
                            WarrantyInYears = 1
                        },
                        new ActiveType() {
                            Id              = Guid.NewGuid(),
                            Description     = "Borrachas, escovas, articulações, fechos e roldanas de esquadrias de alumínio ou PVC.",
                            WarrantyInYears = 2
                        },
                        new ActiveType() {
                            Id              = Guid.NewGuid(),
                            Description     = "Fundações, estruturas principais e periféricas, contenções e arrimos, envolvendo segurança e estabilidade.",
                            WarrantyInYears = 5
                        }
                    }
                );

            modelBuilder.Entity<AddressState>()
                .HasData(
                    new List<AddressState>() {
                        new AddressState() {
                            Id   = Guid.NewGuid(),
                            Name = "São Paulo",
                            Uf   = "SP"
                        },
                        new AddressState() {
                            Id   = Guid.NewGuid(),
                            Name = "Rio de Janeiro",
                            Uf   = "RJ"
                        },
                        new AddressState() {
                            Id   = Guid.NewGuid(),
                            Name = "Recife",
                            Uf   = "RE"
                        }
                    }
                );
        }
    }
}
