﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TreeContext))]
    partial class TreeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.dbColonies", b =>
                {
                    b.Property<int>("IdColony")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdColony"));

                    b.Property<decimal>("Frequency")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Na")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<decimal>("SurfaceH")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("SurfaceM")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("IdColony");

                    b.ToTable("Colonies");
                });

            modelBuilder.Entity("Entities.dbSpecies", b =>
                {
                    b.Property<int>("IdSpecie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSpecie"));

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("scientificName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("IdSpecie");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("Entities.dbTreeMap", b =>
                {
                    b.Property<int>("IdTree")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTree"));

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<decimal>("DB")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("DCEO")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("DCNS")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("EFC")
                        .HasColumnType("int");

                    b.Property<int>("EFT")
                        .HasColumnType("int");

                    b.Property<int>("ESC")
                        .HasColumnType("int");

                    b.Property<int>("EST")
                        .HasColumnType("int");

                    b.Property<decimal>("H")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("IdColony")
                        .HasColumnType("int");

                    b.Property<int>("IdSpecie")
                        .HasColumnType("int");

                    b.Property<int>("NoTree")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Risk")
                        .HasColumnType("int");

                    b.Property<int>("Sa")
                        .HasColumnType("int");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.Property<int>("Xcoordinate")
                        .HasColumnType("int");

                    b.Property<int>("Ycoordinate")
                        .HasColumnType("int");

                    b.Property<int>("Zone")
                        .HasColumnType("int");

                    b.Property<int>("maintenance")
                        .HasColumnType("int");

                    b.HasKey("IdTree");

                    b.HasIndex("IdColony");

                    b.HasIndex("IdSpecie");

                    b.ToTable("TreeMap");
                });

            modelBuilder.Entity("Entities.dbTreeMap", b =>
                {
                    b.HasOne("Entities.dbColonies", "Colony")
                        .WithMany("Trees")
                        .HasForeignKey("IdColony")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.dbSpecies", "Specie")
                        .WithMany("Trees")
                        .HasForeignKey("IdSpecie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colony");

                    b.Navigation("Specie");
                });

            modelBuilder.Entity("Entities.dbColonies", b =>
                {
                    b.Navigation("Trees");
                });

            modelBuilder.Entity("Entities.dbSpecies", b =>
                {
                    b.Navigation("Trees");
                });
#pragma warning restore 612, 618
        }
    }
}
