using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class Context:DbContext
    {
       
        public DbSet<Soba> Sobe { get; set; }


        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentskiDom>().HasKey(sd => new { sd.StudentskiCentarId, sd.StudentskiDomId });
            modelBuilder.Entity<Blok>().HasKey(b => new { b.StudentskiCentarId, b.StudentskiDomId, b.BlokId});
            modelBuilder.Entity<Blok>().HasOne(b => b.StudentskiDom).WithMany(d => d.Blokovi).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Blok>().HasOne(b => b.StudentskiCentar).WithMany(c => c.Blokovi).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Soba>().HasOne(s => s.Blok).WithMany(b => b.Sobe).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Soba>().HasOne(s => s.StudentskiDom).WithMany(b => b.Sobe).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Soba>().HasOne(s => s.StudentskiCentar).WithMany(b => b.Sobe).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Soba>().HasKey(b => new { b.StudentskiCentarId, b.StudentskiDomId, b.BlokId, b.BrojSobe});
            modelBuilder.Entity<Soba>().HasMany(s => s.Studenti).WithOne(s => s.Soba).HasForeignKey(l=>new { l.BrojSobe, l.StudentskiDomId, l.StudentskiCentarId,l.BlokId }).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UplataStanarine>().HasKey(u => new { u.Datum, u.BrojSobe,u.BlokId,u.StudentskiDomId,u.StudentskiCentarId, u.StudentId });
            modelBuilder.Entity<UplataStanarine>().HasOne(u => u.Student).WithMany(s => s.Uplate);
            modelBuilder.Entity<Soba>().HasMany(s=>s.Uplate).WithOne(u=>u.Soba).HasForeignKey(k=>new { k.BrojSobe,k.StudentskiCentarId,k.StudentskiDomId,k.BlokId}).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Uplata>().HasKey(u => new { u.StudentId, u.AdministratorId, u.UplataId });
            modelBuilder.Entity<Administrator>().HasMany(s => s.Uplate_admin);
            modelBuilder.Entity<Student>().HasMany(s => s.Uplate_admin);
            modelBuilder.Entity<StudentskiDom>().HasMany(d => d.Masine);
            modelBuilder.Entity<Rezervacija>().HasKey(r=>new{ r.Termin,r.StudentId,r.MasinaId});
            modelBuilder.Entity<Student>().HasMany(s => s.Rezervacije);
            modelBuilder.Entity<Masina>().HasMany(s => s.Rezervacije);



        }


    }
}
