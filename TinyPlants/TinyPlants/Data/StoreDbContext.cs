using System;
using Microsoft.EntityFrameworkCore;
using TinyPlants.Models;

namespace TinyPlants.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Sku = "CAC001",
                    Name = "Atlantic",
                    Price = 12,
                    Description = "A combination of multiple small cactuses",
                    Image = "",
                    IsFeatured = true
                });
        }

        public DbSet<Product> Products { get; set; }
    }
}
