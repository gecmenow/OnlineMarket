using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);

        IList<Product> GetProducts();
        bool IsRealProductId(int input);
        Product GetProductById(int input);
    }
}
