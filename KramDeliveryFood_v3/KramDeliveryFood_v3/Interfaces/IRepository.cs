using KramDeliveryFood_v3.Models;
using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Interfaces
{
    public interface IRepository
    {
        List<Product> GetProducts();
        Product GetProductById(Guid id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Guid id);
    }
}
