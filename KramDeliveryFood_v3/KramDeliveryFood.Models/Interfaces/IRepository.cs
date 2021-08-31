using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;

namespace KramDelivery.Structure.Interfaces
{
    public interface IRepository
    {
        IList<Product> GetProducts();
        Product GetProductById(Guid id);
        void AddProducts(Product product);
        void UpdateProducts(Product product);
        void DeleteProducts(Product product);
    }
}
