using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using KramDelivery.Domain.Service;
using AutoMapper;

namespace KramDeliverFoodCompleted.Services
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

        public void AddProduct(Product product)
        {
            if (!GetProducts().Any(x => x.Id == product.Id))
            {
                product.Id = Guid.NewGuid();
                _data.BaseProducts.Add(product);
                _serializerService.DoSerialization<Product>(product);
                _loggerService.AddLog("Product was added " + product.Id);
            }
        }

        public IList<Product> GetProductsForApi()
        {
            var unitOfWork = new UnitOfWork();
            var products = unitOfWork.Products.GetProducts();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KramDelivery.Structure.Models.Product, Product>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<Product>>(products);

            return data;
        }

        public IList<Product> GetProducts()
        {
            var data = _serializerService.DoDeserialization<Product>();

            return data;
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

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
