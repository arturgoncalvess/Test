﻿// <auto-generated />
using System;
using InternalErpProject.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternalErpProject.WebAPI.Migrations
{
    [DbContext(typeof(ErpContext))]
    [Migration("20230127123506_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InternalErpProject.WebAPI.Models.PersonModel", b =>
                {
                    b.Property<int>("IdPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EmergencyContact")
                        .HasColumnType("int");

                    b.Property<string>("EmergencyContactName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Hired")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NitPisNit")
                        .HasColumnType("int");

                    b.Property<int>("Rg")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("IdPerson");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            IdPerson = 1,
                            BirthDate = new DateTime(2001, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Fortaleza",
                            Cpf = 89371897,
                            Email = "artur@gmail.com",
                            EmergencyContact = 392139739,
                            EmergencyContactName = "Maria",
                            Hired = false,
                            Name = "Artur Gonçalves",
                            NitPisNit = 186867,
                            Rg = 21787938,
                            State = "Ceará",
                            Telephone = 263846234
                        },
                        new
                        {
                            IdPerson = 2,
                            BirthDate = new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Fortaleza",
                            Cpf = 123123217,
                            Email = "arturP@gmail.com",
                            EmergencyContact = 323354354,
                            EmergencyContactName = "Max",
                            Hired = true,
                            Name = "Artur Pereira",
                            NitPisNit = 434237,
                            Rg = 8324238,
                            State = "Ceará",
                            Telephone = 213136234
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
