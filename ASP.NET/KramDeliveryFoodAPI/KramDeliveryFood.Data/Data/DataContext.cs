﻿using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace KramDeliveryFood.Data.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        private readonly IConfiguration _configuration;
 
        public DataContext()
        {

        }

        public DataContext(IConfiguration config)
        {
            _configuration = config;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasMany(e => e.Products)
                .WithMany(w => w.OrderProducts);
        }
    }
}
