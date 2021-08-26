using KramDelivery.Domain.Models;
using System.Collections.Generic;

namespace KramDelivery.Domain.Interfaces
{
    public interface IProductService
    {
        IList<Product> GetProducts();
    }
}
