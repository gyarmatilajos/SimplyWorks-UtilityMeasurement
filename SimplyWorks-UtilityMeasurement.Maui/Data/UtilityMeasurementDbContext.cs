using Microsoft.EntityFrameworkCore;
using SimplyWorks_UtilityMeasurement.Maui.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplyWorks_UtilityMeasurement.Maui.Data
{
    public class UtilityMeasurementDbContext : DbContext
    {
        public DbSet<Apartment> Apartments => Set<Apartment>();
        public DbSet<Meter> Meters => Set<Meter>();
        public DbSet<Reading> Readings => Set<Reading>();

        public UtilityMeasurementDbContext(DbContextOptions<UtilityMeasurementDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Meter>()
                .HasIndex(m => m.SerialNumber)
                .IsUnique();

            modelBuilder.Entity<Meter>()
                .HasOne(m => m.Apartment)
                .WithMany(a => a.Meters)
                .HasForeignKey(m => m.ApartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reading>()
                .HasOne(r => r.Meter)
                .WithMany(m => m.Readings)
                .HasForeignKey(r => r.MeterId)
                .OnDelete(DeleteBehavior.Cascade);

            // Decimal tárolás: SQLite REAL/NUMERIC keverten kezel, de EF Core oké vele.
            modelBuilder.Entity<Reading>()
                .Property(r => r.Value)
                .HasPrecision(18, 3);
        }

    }
}
