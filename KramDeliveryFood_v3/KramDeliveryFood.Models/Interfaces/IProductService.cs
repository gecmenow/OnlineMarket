using KramDelivery.Structure.Models;
using System.Collections.Generic;

namespace KramDelivery.Structure.Interfaces
{
    public interface IProductService
    {
        IList<Product> GetProducts();
    }
}
