﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TAXI_PROJECT;

#nullable disable

namespace Taxi_Project.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241217144547_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TAXI_PROJECT.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("TAXI_PROJECT.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("TAXI_PROJECT.Mahalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SemtId");

                    b.ToTable("Mahalles");
                });

            modelBuilder.Entity("TAXI_PROJECT.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MahalleId")
                        .HasColumnType("int");

                    b.Property<int>("SemtId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mahalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MahalleId");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("TAXI_PROJECT.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int>("hesapTutari")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.ToTable("Randevus");
                });

            modelBuilder.Entity("TAXI_PROJECT.Semt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.ToTable("Semts");
                });

            modelBuilder.Entity("TAXI_PROJECT.Ilce", b =>
                {
                    b.HasOne("TAXI_PROJECT.Il", "Il")
                        .WithMany("Ilces")
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("TAXI_PROJECT.Mahalle", b =>
                {
                    b.HasOne("TAXI_PROJECT.Semt", "Semt")
                        .WithMany("Mahalles")
                        .HasForeignKey("SemtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semt");
                });

            modelBuilder.Entity("TAXI_PROJECT.Musteri", b =>
                {
                    b.HasOne("TAXI_PROJECT.Mahalle", "Mahalle")
                        .WithMany()
                        .HasForeignKey("MahalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mahalle");
                });

            modelBuilder.Entity("TAXI_PROJECT.Randevu", b =>
                {
                    b.HasOne("TAXI_PROJECT.Musteri", "Musteri")
                        .WithMany("Randevus")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("TAXI_PROJECT.Semt", b =>
                {
                    b.HasOne("TAXI_PROJECT.Ilce", "Ilce")
                        .WithMany("Semts")
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("TAXI_PROJECT.Il", b =>
                {
                    b.Navigation("Ilces");
                });

            modelBuilder.Entity("TAXI_PROJECT.Ilce", b =>
                {
                    b.Navigation("Semts");
                });

            modelBuilder.Entity("TAXI_PROJECT.Musteri", b =>
                {
                    b.Navigation("Randevus");
                });

            modelBuilder.Entity("TAXI_PROJECT.Semt", b =>
                {
                    b.Navigation("Mahalles");
                });
#pragma warning restore 612, 618
        }
    }
}
