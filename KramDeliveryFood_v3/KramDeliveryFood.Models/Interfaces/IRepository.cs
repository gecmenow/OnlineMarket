using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;

namespace KramDelivery.Structure.Interfaces
{
    public interface IRepository
    {
        IList<Product> GetProducts();
        Product GetProductById(Guid id);
        Guid AddProducts(Product provider);
        Guid UpdateProducts(Product provider);
        Guid DeleteProducts();
    }
}
