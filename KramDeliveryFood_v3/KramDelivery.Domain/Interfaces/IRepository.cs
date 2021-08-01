using KramDelivery.Domain.Models;
using System;
using System.Collections.Generic;

namespace KramDelivery.Domain.Interfaces
{
    public interface IRepository
    {
        List<Product> GetProducts();
        Product GetProductById(Guid id);
        Guid AddProducts(Product provider);
        Guid UpdateProducts(Product provider);
        Guid DeleteProducts();
    }
}
