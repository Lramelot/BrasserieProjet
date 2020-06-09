﻿// <auto-generated />
using System;
using BP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BP.Data.Migrations
{
    [DbContext(typeof(BrasserieContext))]
    [Migration("20200608125323_NewMigr")]
    partial class NewMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BP.Core.Domaine.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AlcoolPercentage")
                        .HasColumnType("float");

                    b.Property<int?>("BrewerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrewerId");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlcoolPercentage = 6.5999999999999996,
                            BrewerId = 1,
                            Name = "Leffe Blonde",
                            Price = 2.2000000000000002
                        },
                        new
                        {
                            Id = 2,
                            AlcoolPercentage = 8.5999999999999996,
                            BrewerId = 1,
                            Name = "Leffe Brune",
                            Price = 2.7999999999999998
                        },
                        new
                        {
                            Id = 3,
                            AlcoolPercentage = 7.5,
                            BrewerId = 2,
                            Name = "Chouffe",
                            Price = 3.1000000000000001
                        },
                        new
                        {
                            Id = 4,
                            AlcoolPercentage = 8.8000000000000007,
                            BrewerId = 3,
                            Name = "Chimay Bleue",
                            Price = 3.0
                        },
                        new
                        {
                            Id = 5,
                            AlcoolPercentage = 7.9000000000000004,
                            BrewerId = 3,
                            Name = "Chimay Brune",
                            Price = 2.7999999999999998
                        });
                });

            modelBuilder.Entity("BP.Core.Domaine.Brewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brewers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Abbaye de Leffe"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Achouffe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Abbaye Notre-Dame de Scourmont"
                        });
                });

            modelBuilder.Entity("BP.Core.Domaine.Wholesaler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Wholesalers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HappyHour"
                        },
                        new
                        {
                            Id = 2,
                            Name = "GetDrunk"
                        });
                });

            modelBuilder.Entity("BP.Core.Domaine.WholesalerBeer", b =>
                {
                    b.Property<int>("BeerId")
                        .HasColumnType("int");

                    b.Property<int>("WholesalerId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("BeerId", "WholesalerId");

                    b.HasIndex("WholesalerId");

                    b.ToTable("WholesalerBeers");

                    b.HasData(
                        new
                        {
                            BeerId = 1,
                            WholesalerId = 1,
                            Stock = 38
                        },
                        new
                        {
                            BeerId = 1,
                            WholesalerId = 2,
                            Stock = 12
                        },
                        new
                        {
                            BeerId = 2,
                            WholesalerId = 1,
                            Stock = 18
                        },
                        new
                        {
                            BeerId = 2,
                            WholesalerId = 2,
                            Stock = 21
                        },
                        new
                        {
                            BeerId = 3,
                            WholesalerId = 1,
                            Stock = 5
                        },
                        new
                        {
                            BeerId = 4,
                            WholesalerId = 2,
                            Stock = 12
                        },
                        new
                        {
                            BeerId = 3,
                            WholesalerId = 2,
                            Stock = 18
                        },
                        new
                        {
                            BeerId = 5,
                            WholesalerId = 1,
                            Stock = 16
                        });
                });

            modelBuilder.Entity("BP.Core.Domaine.Beer", b =>
                {
                    b.HasOne("BP.Core.Domaine.Brewer", "Brewer")
                        .WithMany("Beers")
                        .HasForeignKey("BrewerId");
                });

            modelBuilder.Entity("BP.Core.Domaine.WholesalerBeer", b =>
                {
                    b.HasOne("BP.Core.Domaine.Beer", "Beer")
                        .WithMany("WholesalerBeers")
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BP.Core.Domaine.Wholesaler", "Wholesaler")
                        .WithMany("WholesalerBeers")
                        .HasForeignKey("WholesalerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
