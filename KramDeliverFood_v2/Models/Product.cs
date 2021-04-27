using KramDeliverFood_v2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFood_v2.Models
{
    class Product : IProduct
    {
        public List<Product> Products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Омлет доброе утро", Price = 80.00M, Specifications = "221 ккал. б15 ,ж14 ,у5", Description = "яйцо, молоко,зелень,приправы" },
            new Product { Id = Guid.NewGuid(), Name = "Сырники творожные со сметаной", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана" },
            new Product { Id = Guid.NewGuid(), Name = "Каша рисовая молочная", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар" },
        };

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }


    }
}
