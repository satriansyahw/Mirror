﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MirrorDB;

namespace MirrorDB.Migrations
{
    [DbContext(typeof(MirrorDBContext))]
    [Migration("20200324024949_InitialMigrationCOVId19")]
    partial class InitialMigrationCOVId19
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MirrorDB.FakeTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName");

                    b.Property<string>("UserName2");

                    b.Property<string>("UserName3");

                    b.Property<bool>("active_bool")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("insert_by");

                    b.Property<DateTime>("insert_date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 3, 24, 9, 49, 48, 973, DateTimeKind.Local));

                    b.Property<string>("update_by");

                    b.Property<DateTime?>("update_date");

                    b.HasKey("Id");

                    b.ToTable("FakeTable","fake");
                });

            modelBuilder.Entity("MirrorDB.Models.dbMob.DTCovid", b =>
                {
                    b.Property<bool>("active_bool")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("EmpNo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("HPNo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasMaxLength(200);

                    b.Property<string>("Note")
                        .HasMaxLength(300);

                    b.Property<string>("Temp")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<DateTime>("TimeCheck");

                    b.Property<string>("insert_by");

                    b.Property<DateTime>("insert_date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local));

                    b.Property<string>("update_by");

                    b.Property<DateTime?>("update_date");

                    b.HasKey("active_bool");

                    b.HasIndex("EmpNo")
                        .IsUnique();

                    b.HasIndex("HPNo")
                        .IsUnique();

                    b.ToTable("DTCovid","dbMob");
                });

            modelBuilder.Entity("MirrorDB.Models.dbo.MTEmp", b =>
                {
                    b.Property<bool>("active_bool")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("EmpNo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("HPNo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("insert_by");

                    b.Property<DateTime>("insert_date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 3, 24, 9, 49, 48, 974, DateTimeKind.Local));

                    b.Property<string>("update_by");

                    b.Property<DateTime?>("update_date");

                    b.HasKey("active_bool");

                    b.HasIndex("EmpName")
                        .IsUnique();

                    b.HasIndex("EmpNo")
                        .IsUnique();

                    b.ToTable("MTEmp","dbMob");
                });
#pragma warning restore 612, 618
        }
    }
}