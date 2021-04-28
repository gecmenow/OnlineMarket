using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Product : BaseProduct
    {
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public IList<Product> GetProducts()
        {
            var products = new List<Product>();

            if (!FileCheck.BaseProductsFileExist())
            {
                products.Add(new Product { Id = Guid.NewGuid(), Name = "Омлет доброе утро", Price = 80.00M, Specifications = "221 ккал. б15 ,ж14 ,у5", Description = "яйцо, молоко,зелень,приправы" });
                products.Add(new Product { Id = Guid.NewGuid(), Name = "Сырники творожные со сметаной", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана" });
                products.Add(new Product { Id = Guid.NewGuid(), Name = "Каша рисовая молочная", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар" });

                FileCheck.SaveBaseProducts(products);
            }

            products = (List<Product>)FileCheck.ReadBaseProducts();

            return products;
        }

        public Product GetProduct(int id)
        {
            var products = GetProducts();

            var counter = 0;

            Product product = default;

            foreach (var item in products)
            {
                if (counter == id)
                {
                    product = item;
                }

                counter++;
            }

            return product;
        }

        public void AddProductToOrder(Product product)
        {
            FileCheck.ProductsFileExist();

            FileCheck.ProductsFileSave(product); 
        }

        public IList<Product> GetOrderedProducts()
        {
            var products = FileCheck.ReadProductsForOrder();

            return products;
        }
    }
}
