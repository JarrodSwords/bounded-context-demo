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
    [Migration("20220708145143_AddShipment")]
    partial class AddShipment
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
                            Id = new Guid("ff784bab-f9bd-43d1-9ab0-4ee8ae915a8f"),
                            Name = "John",
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = new Guid("5e9762c8-03ea-4a10-b4cc-b704385de152"),
                            Name = "Jane",
                            Surname = "Doe"
                        });
                });

            modelBuilder.Entity("BoundedContextDemo.Infrastructure.Customers.LineItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Units")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ShipmentId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("BoundedContextDemo.Infrastructure.Customers.Shipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("BoundedContextDemo.Infrastructure.Customers.LineItem", b =>
                {
                    b.HasOne("BoundedContextDemo.Infrastructure.Customers.Shipment", null)
                        .WithMany("LineItems")
                        .HasForeignKey("ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoundedContextDemo.Infrastructure.Customers.Shipment", b =>
                {
                    b.Navigation("LineItems");
                });
#pragma warning restore 612, 618
        }
    }
}
