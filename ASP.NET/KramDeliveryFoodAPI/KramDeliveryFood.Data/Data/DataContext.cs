using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using Microsoft.EntityFrameworkCore;

namespace KramDeliveryFood.Data.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=DESKTOP-6TRO3JH; Integrated Security=True;Initial Catalog = KramDeliveryFoodDB");
        }
    }
}
