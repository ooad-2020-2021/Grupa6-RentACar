using ImplementacijaRentAndGo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementacijaRentAndGo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BankovniRacun> BankovniRacun { get; set; }
        public DbSet<Iznajmljivanje> Iznajmljivanje { get; set; }
        public DbSet<Vozac> Vozac { get; set; }
        public DbSet<VozackaDozvola> VozackaDozvola { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankovniRacun>().ToTable("BankovniRacun");
            modelBuilder.Entity<Iznajmljivanje>().ToTable("Iznajmljivanje");
            modelBuilder.Entity<Vozac>().ToTable("Vozac");
            modelBuilder.Entity<VozackaDozvola>().ToTable("VozackaDozvola");
            modelBuilder.Entity<Vozilo>().ToTable("Vozilo");
            

            base.OnModelCreating(modelBuilder);
        } 
    }
}
