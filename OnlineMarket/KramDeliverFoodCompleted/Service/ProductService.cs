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
        private readonly ILoggerService _loggerService;
        private readonly ISerializerService _serializerService;

        public ProductService(IData data, ILoggerService loggerService, ISerializerService serializerService)
        {
            _data = data;
            _loggerService = loggerService;
            _serializerService = serializerService;
        }

        public void AddProduct(Products product)
        {
            if (!GetProducts().Any(x => x.Id == product.Id))
            {
                product.Id = Guid.NewGuid();
                _data.BaseProducts.Add(product);
                _serializerService.DoSerialization<Products>(product);
                _loggerService.AddLog("Product was added " + product.Id);
            }
        }

        public IList<Products> GetProducts()
        {
            var data = _serializerService.DoDeserialization<Products>();

            return data;
        }  

        public bool IsRealProductId(int id)
        {
            var productsLength = GetProducts().Count;

            return id >= 0 && id < productsLength;
        }

        public Products GetProductById(int id)
        {
            var products = GetProducts();
            var counter = 0;
            Products product = default;

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
