﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsCatalogApp.Data;

#nullable disable

namespace ProductsCatalogApp.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20220824062804_abc")]
    partial class abc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductsCatalogApp.Entities.Catagory", b =>
                {
                    b.Property<int>("CatagoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatagoryID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatagoryID");

                    b.ToTable("Catagories");
                });

            modelBuilder.Entity("ProductsCatalogApp.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CatagoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CatagoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductsCatalogApp.Entities.Product", b =>
                {
                    b.HasOne("ProductsCatalogApp.Entities.Catagory", "Catagory")
                        .WithMany("Products")
                        .HasForeignKey("CatagoryID");

                    b.Navigation("Catagory");
                });

            modelBuilder.Entity("ProductsCatalogApp.Entities.Catagory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}