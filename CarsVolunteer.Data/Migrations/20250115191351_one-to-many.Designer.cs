﻿// <auto-generated />
using System;
using CarsVolunteer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarsVolunteer.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250115191351_one-to-many")]
    partial class onetomany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountPlacesInCar")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DetailsOfCarId")
                        .HasColumnType("int");

                    b.Property<int>("IdOfCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdOfVolunteer")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOfTraveling")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VolunteerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DetailsOfCarId");

                    b.HasIndex("VolunteerId");

                    b.ToTable("travels");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountTravelingInMonth")
                        .HasColumnType("int");

                    b.Property<int>("DetailsOfCarId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetailsOfCarId");

                    b.ToTable("volunteers");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Travel", b =>
                {
                    b.HasOne("CarsVolunteer.Core.Entities.Customer", null)
                        .WithMany("travelList")
                        .HasForeignKey("CustomerId");

                    b.HasOne("CarsVolunteer.Core.Entities.Car", "DetailsOfCar")
                        .WithMany()
                        .HasForeignKey("DetailsOfCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarsVolunteer.Core.Entities.Volunteer", null)
                        .WithMany("travelList")
                        .HasForeignKey("VolunteerId");

                    b.Navigation("DetailsOfCar");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Volunteer", b =>
                {
                    b.HasOne("CarsVolunteer.Core.Entities.Car", "DetailsOfCar")
                        .WithMany()
                        .HasForeignKey("DetailsOfCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailsOfCar");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Customer", b =>
                {
                    b.Navigation("travelList");
                });

            modelBuilder.Entity("CarsVolunteer.Core.Entities.Volunteer", b =>
                {
                    b.Navigation("travelList");
                });
#pragma warning restore 612, 618
        }
    }
}
