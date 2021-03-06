﻿// <auto-generated />
using System;
using MegaDesk__Mine_.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDesk__Mine_.Migrations
{
    [DbContext(typeof(MegaDesk__Mine_Context))]
    [Migration("20200223193404_New")]
    partial class New
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDesk__Mine_.Pages.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("clientFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("deskDepth")
                        .HasColumnType("float");

                    b.Property<double>("deskWidth")
                        .HasColumnType("float");

                    b.Property<int>("numDrawers")
                        .HasColumnType("int");

                    b.Property<double>("quoteTotal")
                        .HasColumnType("float");

                    b.Property<int>("rushOption")
                        .HasColumnType("int");

                    b.Property<DateTime>("submitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("surfaceMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
