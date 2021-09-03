using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;

namespace KramDelivery.Structure.Interfaces
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        Product GetProductById(Guid id);
        IList<Product> GetProductsByCategoryName(string category);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
