using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    interface IProductService
    {
        void AddProduct(Product product);

        IList<Product> GetProducts();
    }
}
