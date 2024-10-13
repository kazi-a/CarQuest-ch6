﻿// <auto-generated />
using CarQuest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarQuest.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20241009205046_UpdateSeedData")]
    partial class UpdateSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarQuest.Models.Customers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("GenderIdentity")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Zip")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "abc@xyz.edu",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "James",
                            LastName = "Bond"
                        },
                        new
                        {
                            ID = 3,
                            FirstName = "Tom",
                            LastName = "Cruise"
                        },
                        new
                        {
                            ID = 4,
                            FirstName = "Johnny",
                            LastName = "Depp"
                        },
                        new
                        {
                            ID = 5,
                            FirstName = "Leo",
                            LastName = "Blade"
                        },
                        new
                        {
                            ID = 6,
                            Email = "emma@stone.com",
                            FirstName = "Emma",
                            LastName = "Stone"
                        },
                        new
                        {
                            ID = 7,
                            Email = "chris@evans.com",
                            FirstName = "Chris",
                            LastName = "Evans"
                        },
                        new
                        {
                            ID = 8,
                            Email = "scarlett@johansson.com",
                            FirstName = "Scarlett",
                            LastName = "Johansson"
                        },
                        new
                        {
                            ID = 9,
                            Email = "robert@downey.com",
                            FirstName = "Robert",
                            LastName = "Downey Jr."
                        },
                        new
                        {
                            ID = 10,
                            Email = "natalie@portman.com",
                            FirstName = "Natalie",
                            LastName = "Portman"
                        },
                        new
                        {
                            ID = 11,
                            Email = "harrison@ford.com",
                            FirstName = "Harrison",
                            LastName = "Ford"
                        },
                        new
                        {
                            ID = 12,
                            Email = "denzel@washington.com",
                            FirstName = "Denzel",
                            LastName = "Washington"
                        },
                        new
                        {
                            ID = 13,
                            Email = "leonardo@dicaprio.com",
                            FirstName = "Leonardo",
                            LastName = "DiCaprio"
                        },
                        new
                        {
                            ID = 14,
                            Email = "angelina@jolie.com",
                            FirstName = "Angelina",
                            LastName = "Jolie"
                        },
                        new
                        {
                            ID = 15,
                            Email = "brad@pitt.com",
                            FirstName = "Brad",
                            LastName = "Pitt"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
