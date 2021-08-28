using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using KramDelivery.Domain.Service;
using AutoMapper;
using KramDelivery.Structure.Interfaces;

namespace KramDeliverFoodCompleted.Services
{
    public class ProductService : Interfaces.IProductService
    {
        private readonly Interfaces.IData _data;
        private readonly ILoggerService _loggerService;
        private readonly ISerializerService _serializerService;

        public ProductService(Interfaces.IData data, ILoggerService loggerService, ISerializerService serializerService)
        {
            _data = data;
            _loggerService = loggerService;
            _serializerService = serializerService;
        }

        public void AddProduct(Product product)
        {
            if (!GetProducts().Any(x => x.ProductId == product.ProductId))
            {
                product.ProductId = Guid.NewGuid();
                _data.BaseProducts.Add(product);
                _serializerService.DoSerialization<Product>(product);
                _loggerService.AddLog("Product was added " + product.ProductId);
            }
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

        public IList<KramDelivery.Structure.Models.Product> GetProductsForApi()
        {
            var unitOfWork = new UnitOfWork();
            var products = unitOfWork.Products.GetProducts();

            return products;
        }

        public IList<KramDelivery.Structure.Models.Product> GetProductsByCategoryName(string category)
        {
            var unitOfWork = new UnitOfWork();
            var products = unitOfWork.Products.GetProducts().Where(p => p.CategoryName == category).ToList();

            return products;
        }

        public KramDelivery.Structure.Models.Product GetProductById(Guid id)
        {
            var unitOfWork = new UnitOfWork();
            var product = unitOfWork.Products.GetProductById(id);

            return product;
        }

        public void AddProduct(KramDelivery.Structure.Models.Product product)
        {
            var unitOfWork = new UnitOfWork();
            unitOfWork.Products.AddProduct(product);
            unitOfWork.Save();
        }

        public void UpdateProduct(KramDelivery.Structure.Models.Product product)
        {
            var unitOfWork = new UnitOfWork();
            unitOfWork.Products.UpdateProduct(product);
            unitOfWork.Save();
        }

        public void DeleteProduct(KramDelivery.Structure.Models.Product product)
        {
            var unitOfWork = new UnitOfWork();
            unitOfWork.Products.DeleteProduct(product);
            unitOfWork.Save();
        }
    }
}
