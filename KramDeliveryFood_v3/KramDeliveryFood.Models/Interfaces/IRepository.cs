using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;

namespace KramDelivery.Structure.Interfaces
{
    public interface IRepository
    {
        IList<Product> GetProducts();
        Product GetProductById(Guid id);
        void AddProduct(Product provider);
        void UpdateProduct(Product provider);
        void DeleteProduct(Product product);
    }
}
