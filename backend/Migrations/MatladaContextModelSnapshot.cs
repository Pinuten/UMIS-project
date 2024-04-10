﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(MatladaContext))]
    partial class MatladaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Matlada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("EatenCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Matlador");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 10, 23, 30, 30, 270, DateTimeKind.Local).AddTicks(1510),
                            EatenCount = 0,
                            Guid = "b4b0c8cc-63f4-47e7-99e7-c86cb8661cb2",
                            Name = "My First Matlada",
                            Size = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 10, 23, 30, 30, 270, DateTimeKind.Local).AddTicks(1550),
                            EatenCount = 0,
                            Guid = "4ceeb16e-d32a-459f-b81f-d88b60dafd0b",
                            Name = "My Second Matlada",
                            Size = 1
                        });
                });

            modelBuilder.Entity("Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Eaten")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
