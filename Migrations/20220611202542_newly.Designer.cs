﻿// <auto-generated />
using System;
using Data_Access.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data_Access.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220611202542_newly")]
    partial class newly
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data_Access.Models.Character", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KnownFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            DoB = new DateTime(2022, 6, 11, 22, 25, 42, 33, DateTimeKind.Local).AddTicks(4850),
                            FullName = "Tony Stark",
                            Gender = "Female",
                            KnownFor = "Iron man",
                            Nationality = "American",
                            Status = false
                        },
                        new
                        {
                            Id = "2",
                            DoB = new DateTime(2022, 6, 11, 22, 25, 42, 33, DateTimeKind.Local).AddTicks(4900),
                            FullName = "Tony Dark",
                            Gender = "Trans",
                            KnownFor = "Spider man",
                            Nationality = "American psycho",
                            Status = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}