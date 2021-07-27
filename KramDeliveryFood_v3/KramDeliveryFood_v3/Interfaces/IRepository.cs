using KramDeliveryFood_v3.Models;
using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Interfaces
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
