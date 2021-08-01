using KramDelivery.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace KramDeliveryFood.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=DESKTOP-6TRO3JH; Integrated Security=True;Initial Catalog = KramDeliveryFoodDB");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasMany(e => e.Products)
                .WithMany(w => w.OrderProducts);
        }
    }
}
