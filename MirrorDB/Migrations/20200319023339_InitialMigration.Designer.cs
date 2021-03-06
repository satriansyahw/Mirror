﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MirrorDB;

namespace MirrorDB.Migrations
{
    [DbContext(typeof(MirrorDBContext))]
    [Migration("20200319023339_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserName2");

                    b.Property<string>("UserName3");

                    b.HasKey("Id");

                    b.HasIndex("UserName2")
                        .IsUnique()
                        .HasFilter("[UserName2] IS NOT NULL");

                    b.ToTable("FakeTable","fake");
                });
#pragma warning restore 612, 618
        }
    }
}
