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
        private readonly ICacheService _cacheService;

        delegate void AddToCacheDelegate(Product product);

        public ProductService(IData data, ILoggerService loggerService, ISerializerService serializerService, ICacheService cacheService)
        {
            _data = data;
            _loggerService = loggerService;
            _serializerService = serializerService;
            _cacheService = cacheService;
        }

        public void AddProduct(Product product)
        {
            if (GetProducts() == null)
            {
                _serializerService.DoSerialization<Product>(product);
                AddToCacheDelegate addToCache = _cacheService.AddToCache;
                addToCache(product);
                _loggerService.AddLog("Product was added " + product.Id);
            }
            else if (!GetProducts().Any(x => x.Id == product.Id))
            {
                _serializerService.DoSerialization<Product>(product);
                AddToCacheDelegate addToCache = _cacheService.AddToCache;
                addToCache(product);
                _loggerService.AddLog("Product was added " + product.Id);
            }
        }

        public IList<Product> GetProducts()
        {
            if (_cacheService.GetFromCache() != null)
            {
                return _cacheService.GetFromCache();
            }

            _data.BaseProducts = _serializerService.DoDeserialization<Product>();

            if (_data.BaseProducts != null)
            {
                AddToCacheDelegate addToCache = _cacheService.AddToCache;

                foreach (var product in _data.BaseProducts)
                {
                    addToCache(product);
                }
            }

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
