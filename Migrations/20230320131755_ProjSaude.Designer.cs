﻿// <auto-generated />
using Hotsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotsite.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230320131755_ProjSaude")]
    partial class ProjSaude
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hotsite.Models.Interesse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(156) CHARACTER SET utf8mb4")
                        .HasMaxLength(156);

                    b.Property<string>("Mensagem")
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(156) CHARACTER SET utf8mb4")
                        .HasMaxLength(156);

                    b.HasKey("Id");

                    b.ToTable("Interesses");
                });
#pragma warning restore 612, 618
        }
    }
}
