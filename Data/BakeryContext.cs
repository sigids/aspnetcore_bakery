using Bakery.Data.Configurations;
using Bakery.Models;
    using Microsoft.EntityFrameworkCore;

    namespace Bakery.Data
    {
        public class BakeryContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Bakery;Trusted_Connection=True;MultipleActiveResultSets=true");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
            }



        }
    }