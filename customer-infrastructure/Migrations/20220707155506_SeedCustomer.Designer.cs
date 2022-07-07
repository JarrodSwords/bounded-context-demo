﻿// <auto-generated />
using System;
using BoundedContextDemo.Infrastructure.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoundedContextDemo.Infrastructure.Customers.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220707155506_SeedCustomer")]
    partial class SeedCustomer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoundedContextDemo.Infrastructure.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f4cfb45-0b44-4744-929e-1e6a7248d343"),
                            Name = "John",
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = new Guid("d5d297ec-9f3f-43fa-bdcb-4ea28da97bcd"),
                            Name = "Jane",
                            Surname = "Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
