using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class StoreContext : IData
    {
        public IList<Product> BaseProducts { get; set; }
        public IList<Order> Orders { get; set; }
        public Order Order { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IList<Product> OrderProducts { get; set; }

        public StoreContext()
        {
            BaseProducts = new List<Product>();
        }

        public void InitProducts()
        {
            BaseProducts.Add(
                new Product { Id = Guid.Parse("db7fc833-bed5-4dab-b220-dc54a769839b"), Name = "Омлет доброе утро", Price = 80.00M, Specifications = "221 ккал. б15 ,ж14 ,у5", Description = "яйцо, молоко,зелень,приправы" }
            );
            BaseProducts.Add(
                new Product { Id = Guid.Parse("2361e2c1-51b3-4dbb-af95-3adfcbfd3fdd"), Name = "Сырники творожные со сметаной", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана" }
                );
            BaseProducts.Add(
                new Product { Id = Guid.Parse("dc5df95a-16ef-4dd2-9ebf-68c2074388db"), Name = "Каша рисовая молочная", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар" }
                );
        }
    }
}
