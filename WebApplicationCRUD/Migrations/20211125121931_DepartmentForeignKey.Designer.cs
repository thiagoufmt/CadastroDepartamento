﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationCRUD.Data;

namespace WebApplicationCRUD.Migrations
{
    [DbContext(typeof(WebApplicationCRUDContext))]
    [Migration("20211125121931_DepartmentForeignKey")]
    partial class DepartmentForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationCRUD.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebApplicationCRUD.Models.RecordeVendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Quantidade")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("RecordeVendas");
                });

            modelBuilder.Entity("WebApplicationCRUD.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("SalarioBase")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Vendedors");
                });

            modelBuilder.Entity("WebApplicationCRUD.Models.RecordeVendas", b =>
                {
                    b.HasOne("WebApplicationCRUD.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("WebApplicationCRUD.Models.Vendedor", b =>
                {
                    b.HasOne("WebApplicationCRUD.Models.Department", "Department")
                        .WithMany("Vendedors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}