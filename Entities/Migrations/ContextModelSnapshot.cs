﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Administrator", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministratorId");

                    b.HasIndex("StudentskiCentarId");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Entities.Blok", b =>
                {
                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiDomId")
                        .HasColumnType("int");

                    b.Property<int>("BlokId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentskiCentarId", "StudentskiDomId", "BlokId");

                    b.HasIndex("StudentskiDomId", "StudentskiCentarId");

                    b.ToTable("Blok");
                });

            modelBuilder.Entity("Entities.Masina", b =>
                {
                    b.Property<int>("MasinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kapacitet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiDomId")
                        .HasColumnType("int");

                    b.HasKey("MasinaId");

                    b.HasIndex("StudentskiCentarId");

                    b.HasIndex("StudentskiDomId", "StudentskiCentarId");

                    b.ToTable("Masina");
                });

            modelBuilder.Entity("Entities.Rezervacija", b =>
                {
                    b.Property<DateTime>("Termin")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("MasinaId")
                        .HasColumnType("int");

                    b.HasKey("Termin", "StudentId", "MasinaId");

                    b.HasIndex("MasinaId");

                    b.HasIndex("StudentId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Entities.Soba", b =>
                {
                    b.Property<int>("BrojSobe")
                        .HasColumnType("int");

                    b.Property<int>("BlokId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiDomId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<string>("Kategorija")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrojSobe", "BlokId", "StudentskiDomId", "StudentskiCentarId");

                    b.HasIndex("StudentskiCentarId", "StudentskiDomId");

                    b.HasIndex("BlokId", "StudentskiDomId", "StudentskiCentarId");

                    b.ToTable("Soba");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlokId")
                        .HasColumnType("int");

                    b.Property<int>("BrojDorucaka")
                        .HasColumnType("int");

                    b.Property<string>("BrojIndeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrojRucaka")
                        .HasColumnType("int");

                    b.Property<int>("BrojSobe")
                        .HasColumnType("int");

                    b.Property<int>("BrojVecera")
                        .HasColumnType("int");

                    b.Property<string>("Finansiranje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PozivNaBroj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StanjeNaRacunu")
                        .HasColumnType("float");

                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiDomId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("StudentskiCentarId");

                    b.HasIndex("StudentskiDomId", "StudentskiCentarId");

                    b.HasIndex("BlokId", "StudentskiDomId", "StudentskiCentarId");

                    b.HasIndex("BrojSobe", "BlokId", "StudentskiDomId", "StudentskiCentarId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Entities.StudentskiCentar", b =>
                {
                    b.Property<int>("StudentskiCentarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentskiCentarId");

                    b.ToTable("StudentskiCentar");
                });

            modelBuilder.Entity("Entities.StudentskiDom", b =>
                {
                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiDomId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentskiCentarId", "StudentskiDomId");

                    b.ToTable("StudentskiDom");
                });

            modelBuilder.Entity("Entities.Uplata", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<int>("UplataId")
                        .HasColumnType("int");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.Property<string>("SvrhaUplate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId", "AdministratorId", "UplataId");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("Entities.UplataStanarine", b =>
                {
                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("BrojSobe")
                        .HasColumnType("int");

                    b.Property<int>("BlokId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiDomId")
                        .HasColumnType("int");

                    b.Property<int>("StudentskiCentarId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.HasKey("Datum", "BrojSobe", "BlokId", "StudentskiDomId", "StudentskiCentarId", "StudentId");

                    b.HasIndex("StudentId");

                    b.HasIndex("StudentskiCentarId", "StudentskiDomId", "BlokId");

                    b.HasIndex("BrojSobe", "StudentskiCentarId", "StudentskiDomId", "BlokId");

                    b.ToTable("UplataStanarine");
                });

            modelBuilder.Entity("Entities.Administrator", b =>
                {
                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany("Administratori")
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentskiCentar");
                });

            modelBuilder.Entity("Entities.Blok", b =>
                {
                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.StudentskiDom", "StudentskiDom")
                        .WithMany("Blokovi")
                        .HasForeignKey("StudentskiDomId", "StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StudentskiCentar");

                    b.Navigation("StudentskiDom");
                });

            modelBuilder.Entity("Entities.Masina", b =>
                {
                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.StudentskiDom", "StudentskiDom")
                        .WithMany("Masine")
                        .HasForeignKey("StudentskiDomId", "StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StudentskiCentar");

                    b.Navigation("StudentskiDom");
                });

            modelBuilder.Entity("Entities.Rezervacija", b =>
                {
                    b.HasOne("Entities.Masina", "Masina")
                        .WithMany("Rezervacije")
                        .HasForeignKey("MasinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Rezervacije")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Masina");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.Soba", b =>
                {
                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.StudentskiDom", "StudentskiDom")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId", "StudentskiDomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Blok", "Blok")
                        .WithMany("Sobe")
                        .HasForeignKey("BlokId", "StudentskiDomId", "StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Blok");

                    b.Navigation("StudentskiCentar");

                    b.Navigation("StudentskiDom");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany("Studenti")
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.StudentskiDom", "StudentskiDom")
                        .WithMany("Studenti")
                        .HasForeignKey("StudentskiDomId", "StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Blok", "Blok")
                        .WithMany("Studenti")
                        .HasForeignKey("BlokId", "StudentskiDomId", "StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Soba", "Soba")
                        .WithMany("Studenti")
                        .HasForeignKey("BrojSobe", "BlokId", "StudentskiDomId", "StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Blok");

                    b.Navigation("Soba");

                    b.Navigation("StudentskiCentar");

                    b.Navigation("StudentskiDom");
                });

            modelBuilder.Entity("Entities.StudentskiDom", b =>
                {
                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany("Domovi")
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StudentskiCentar");
                });

            modelBuilder.Entity("Entities.Uplata", b =>
                {
                    b.HasOne("Entities.Administrator", "Administrator")
                        .WithMany("Uplate_admin")
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Uplate_admin")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrator");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.UplataStanarine", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Uplate")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.StudentskiCentar", "StudentskiCentar")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.StudentskiDom", "StudentskiDom")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId", "StudentskiDomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Blok", "Blok")
                        .WithMany()
                        .HasForeignKey("StudentskiCentarId", "StudentskiDomId", "BlokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Soba", "Soba")
                        .WithMany("Uplate")
                        .HasForeignKey("BrojSobe", "StudentskiCentarId", "StudentskiDomId", "BlokId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Blok");

                    b.Navigation("Soba");

                    b.Navigation("Student");

                    b.Navigation("StudentskiCentar");

                    b.Navigation("StudentskiDom");
                });

            modelBuilder.Entity("Entities.Administrator", b =>
                {
                    b.Navigation("Uplate_admin");
                });

            modelBuilder.Entity("Entities.Blok", b =>
                {
                    b.Navigation("Sobe");

                    b.Navigation("Studenti");
                });

            modelBuilder.Entity("Entities.Masina", b =>
                {
                    b.Navigation("Rezervacije");
                });

            modelBuilder.Entity("Entities.Soba", b =>
                {
                    b.Navigation("Studenti");

                    b.Navigation("Uplate");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Navigation("Rezervacije");

                    b.Navigation("Uplate");

                    b.Navigation("Uplate_admin");
                });

            modelBuilder.Entity("Entities.StudentskiCentar", b =>
                {
                    b.Navigation("Administratori");

                    b.Navigation("Domovi");

                    b.Navigation("Studenti");
                });

            modelBuilder.Entity("Entities.StudentskiDom", b =>
                {
                    b.Navigation("Blokovi");

                    b.Navigation("Masine");

                    b.Navigation("Studenti");
                });
#pragma warning restore 612, 618
        }
    }
}
