using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KramDeliverFoodCompleted.Service
{
    public class ProductService : IProductService
    {
        private readonly IData _data;
<<<<<<< HEAD
        private readonly ILoggerService _loggerService;

        public ProductService(IData data, ILoggerService loggerService)
        {
            _data = data;
            _loggerService = loggerService;
=======

        public ProductService(IData data)
        {
            _data = data;
>>>>>>> main
        }

        public void AddProduct(Product product)
        {
            if (!GetProducts().Any(x => x.Id == product.Id))
            {
                product.Id = Guid.NewGuid();
                _data.BaseProducts.Add(product);
<<<<<<< HEAD
                _loggerService.AddLog("Product was added " + product.Id);
=======
>>>>>>> main
            }
        }

        public IList<Product> GetProducts()
        {
            return _data.BaseProducts;
        }  

        public bool IsRealProductId(int id)
        {
            var productsLength = GetProducts().Count;

            return id >= 0 && id < productsLength;
        }

        public Product GetProductById(int id)
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
    }
}
