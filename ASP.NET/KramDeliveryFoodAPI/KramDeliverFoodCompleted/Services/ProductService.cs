using System;
using System.Collections.Generic;
using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;

namespace KramDeliverFoodCompleted.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;
        private ICategoryService _categoryService;

        public ProductService(IUnitOfWork unitOfWork, ICategoryService categoryService)
        {
            _unitOfWork = unitOfWork;
            _categoryService = categoryService;
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
            var category = _categoryService.GetCategoryById(product.CategoryId);
            product.CategoryName = category.Name;
            _unitOfWork.Product.AddProduct(product);
            _unitOfWork.Save();
        }

        public void UpdateProduct(Product product)
        {
            var category = _categoryService.GetCategoryById(product.CategoryId);
            product.CategoryName = category.Name;
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
