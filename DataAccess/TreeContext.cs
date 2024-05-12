using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class TreeContext : DbContext
    {
        public DbSet<dbColonies> Colonies { get; set; }

        public DbSet<dbSpecies> Species { get; set; }

        public DbSet<dbTreeMap> TreeMap { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"Server=localhost; TrustServerCertificate=True; Database=TreeMapDB; Trusted_Connection=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<dbColonies>()
                .HasMany(e => e.Trees)
                .WithOne(e => e.Colony)
                .HasForeignKey(e => e.IdColony)
                .IsRequired();

            modelBuilder.Entity<dbSpecies>()
                .HasMany(e => e.Trees)
                .WithOne(e => e.Specie)
                .HasForeignKey(e => e.IdSpecie)
                .IsRequired();

            base.OnModelCreating(modelBuilder);

        }


    }
}
