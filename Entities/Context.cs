using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class Context:DbContext
    {
       
        public DbSet<Soba> Soba { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Blok> Blok { get; set; }
        public DbSet<Masina> Masina { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<StudentskiCentar> StudentskiCentar{ get; set; }
        public DbSet<StudentskiDom> StudentskiDom { get; set; }
        public DbSet<Uplata> Uplata { get; set; }
        public DbSet<UplataStanarine> UplataStanarine { get; set; }


        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentskiCentar>().HasMany(d => d.Domovi).WithOne(d => d.StudentskiCentar).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StudentskiDom>().HasKey(sd => new { sd.StudentskiCentarId, sd.StudentskiDomId });
            modelBuilder.Entity<StudentskiDom>().HasMany(d => d.Blokovi).WithOne(b => b.StudentskiDom).HasForeignKey(k => new {k.StudentskiDomId , k.StudentskiCentarId}).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Blok>().HasKey(b => new { b.StudentskiCentarId, b.StudentskiDomId, b.BlokId});
            modelBuilder.Entity<Blok>().HasMany(d => d.Sobe).WithOne(b => b.Blok).HasForeignKey(k => new { k.BlokId, k.StudentskiDomId , k.StudentskiCentarId}).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Soba>().HasKey(b => new { b.BrojSobe, b.BlokId, b.StudentskiDomId,b.StudentskiCentarId});
            modelBuilder.Entity<Student>().HasOne(s => s.Soba).WithMany(s => s.Studenti).HasForeignKey(l=>new { l.BrojSobe, l.BlokId, l.StudentskiDomId, l.StudentskiCentarId}).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>().HasOne(s => s.Blok).WithMany(s => s.Studenti).HasForeignKey(l => new {l.BlokId, l.StudentskiDomId, l.StudentskiCentarId}).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>().HasOne(s => s.StudentskiDom).WithMany(s => s.Studenti).HasForeignKey(l => new { l.StudentskiDomId, l.StudentskiCentarId }).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>().HasOne(s => s.StudentskiCentar).WithMany(s => s.Studenti).HasForeignKey(l => new { l.StudentskiCentarId }).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UplataStanarine>().HasKey(u => new { u.Datum, u.BrojSobe,u.BlokId,u.StudentskiDomId,u.StudentskiCentarId, u.StudentId });
            modelBuilder.Entity<UplataStanarine>().HasOne(u => u.Student).WithMany(s => s.Uplate);
            modelBuilder.Entity<Soba>().HasMany(s=>s.Uplate).WithOne(u=>u.Soba).HasForeignKey(k=>new { k.BrojSobe,k.StudentskiCentarId,k.StudentskiDomId,k.BlokId}).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Uplata>().HasKey(u => new { u.StudentId, u.AdministratorId, u.UplataId });
            modelBuilder.Entity<Administrator>().HasMany(s => s.Uplate_admin);
            modelBuilder.Entity<Student>().HasMany(s => s.Uplate_admin);
            modelBuilder.Entity<StudentskiDom>().HasMany(d => d.Masine).WithOne(m => m.StudentskiDom).HasForeignKey(k => new { k.StudentskiDomId, k.StudentskiCentarId }).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Rezervacija>().HasKey(r=>new{ r.Termin,r.StudentId,r.MasinaId});
            modelBuilder.Entity<Student>().HasMany(s => s.Rezervacije).WithOne(r => r.Student);
            modelBuilder.Entity<Masina>().HasMany(s => s.Rezervacije).WithOne(m => m.Masina);



        }


    }
}
