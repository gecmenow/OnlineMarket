using System;
using System.Collections.Generic;
using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;

namespace KramDeliverFoodCompleted.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Product> GetAllProducts()
        {
            return _unitOfWork.Product.GetAllProducts();
        }

        public IList<Product> GetProductsByCategoryName(string category)
        {
            return _unitOfWork.Product.GetProductsByCategoryName(category);
        }

        public Product GetProductById(Guid id)
        {
            return _unitOfWork.Product.GetProductById(id);
        }

        public void AddProduct(Product product)
        {
            _unitOfWork.Product.AddProduct(product);
            _unitOfWork.Save();
        }

        public void UpdateProduct(Product product)
        {
            _unitOfWork.Product.UpdateProduct(product);
            _unitOfWork.Save();
        }

        public void DeleteProduct(Product product)
        {
            _unitOfWork.Product.RemoveProduct(product);
            _unitOfWork.Save();
        }
    }
}
