﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using newNet.Data;

namespace newNet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200116142040_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("newNet.Models.ChargeLog", b =>
                {
                    b.Property<int>("ChargeLogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("PlazaId");

                    b.Property<int>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("ChargeLogId");

                    b.ToTable("ChargeLogs");
                });

            modelBuilder.Entity("newNet.Models.Plaza", b =>
                {
                    b.Property<int>("PlazaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<string>("PlazaName");

                    b.HasKey("PlazaId");

                    b.ToTable("Plazas");
                });

            modelBuilder.Entity("newNet.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AccountBalance");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("NIN");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<double>("PhoneNumber");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("newNet.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlateNumber");

                    b.Property<string>("TagNumber");

                    b.Property<string>("VehicleName");

                    b.Property<int>("VehicleOwnerId");

                    b.Property<string>("VehicleType");

                    b.HasKey("VehicleId");

                    b.HasIndex("VehicleOwnerId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("newNet.Models.Vehicle", b =>
                {
                    b.HasOne("newNet.Models.User", "VehicleOwner")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleOwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
