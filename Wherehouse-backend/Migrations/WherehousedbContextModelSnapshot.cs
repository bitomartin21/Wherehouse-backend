﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wherehouse_backend.Models;

#nullable disable

namespace Wherehouse_backend.Migrations
{
    [DbContext(typeof(WherehousedbContext))]
    partial class WherehousedbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Wherehouse_backend.Models.Alkalmazott", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("Fizetes")
                        .HasColumnType("int(11)")
                        .HasColumnName("fizetes");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nev");

                    b.Property<string>("Pozicio")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)")
                        .HasColumnName("pozicio");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("alkalmazott", (string)null);
                });

            modelBuilder.Entity("Wherehouse_backend.Models.Birtokolt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("Raktarid")
                        .HasColumnType("int(11)")
                        .HasColumnName("raktarid");

                    b.Property<int>("Tulajid")
                        .HasColumnType("int(11)")
                        .HasColumnName("tulajid");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Raktarid" }, "raktarid")
                        .IsUnique();

                    b.HasIndex(new[] { "Tulajid" }, "tulajid");

                    b.ToTable("birtokolt", (string)null);
                });

            modelBuilder.Entity("Wherehouse_backend.Models.Raktar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("Ar")
                        .HasColumnType("int(20)")
                        .HasColumnName("ar");

                    b.Property<string>("Cím")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cím");

                    b.Property<string>("Kepurl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("kepurl");

                    b.Property<string>("Meret")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("meret");

                    b.Property<string>("Tipus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipus");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("raktar", (string)null);
                });

            modelBuilder.Entity("Wherehouse_backend.Models.Tulajdonos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nev");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tulajdonos", (string)null);
                });

            modelBuilder.Entity("Wherehouse_backend.Models.Birtokolt", b =>
                {
                    b.HasOne("Wherehouse_backend.Models.Raktar", "Raktar")
                        .WithOne("Birtokolt")
                        .HasForeignKey("Wherehouse_backend.Models.Birtokolt", "Raktarid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("birtokolt_ibfk_1");

                    b.HasOne("Wherehouse_backend.Models.Tulajdonos", "Tulaj")
                        .WithMany("Birtokolts")
                        .HasForeignKey("Tulajid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("birtokolt_ibfk_2");

                    b.Navigation("Raktar");

                    b.Navigation("Tulaj");
                });

            modelBuilder.Entity("Wherehouse_backend.Models.Raktar", b =>
                {
                    b.Navigation("Birtokolt");
                });

            modelBuilder.Entity("Wherehouse_backend.Models.Tulajdonos", b =>
                {
                    b.Navigation("Birtokolts");
                });
#pragma warning restore 612, 618
        }
    }
}
