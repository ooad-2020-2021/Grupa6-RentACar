using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentAndGo.Models;

namespace RentAndGo.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<BankovniRacun> BankovniRacun { get; set; }
        public DbSet<Iznajmljivanje> Iznajmljivanje { get; set; }
        public DbSet<KorisnikSaNalogom> KorisnikSaNalogom { get; set; }
        public DbSet<Vozac> Vozac { get; set; }
        public DbSet<VozackaDozvola> VozackaDozvola { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<BankovniRacun>().ToTable("BankovniRacun");
            modelBuilder.Entity<Iznajmljivanje>().ToTable("Iznajmljivanje");
            modelBuilder.Entity<Vozac>().ToTable("Vozac");
            modelBuilder.Entity<VozackaDozvola>().ToTable("VozackaDozvola");
            modelBuilder.Entity<Vozilo>().ToTable("Vozilo");
        }
    }
}
