﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_.net.Database;

#nullable disable

namespace project.net.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("project_.net.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("project_.net.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("project_.net.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("clientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("nbPlacesRes")
                        .HasColumnType("int");

                    b.Property<int?>("restaurantID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clientID");

                    b.HasIndex("restaurantID");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("project_.net.Models.Restaurant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Localization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbPlaces")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("project_.net.Models.Category", b =>
                {
                    b.HasOne("project_.net.Models.Restaurant", null)
                        .WithMany("categories")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("project_.net.Models.Reservation", b =>
                {
                    b.HasOne("project_.net.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientID");

                    b.HasOne("project_.net.Models.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("restaurantID");

                    b.Navigation("client");

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("project_.net.Models.Restaurant", b =>
                {
                    b.Navigation("categories");
                });
#pragma warning restore 612, 618
        }
    }
}