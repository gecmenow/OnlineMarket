using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IProductService
    {
        public void AddProduct(Product product);

        public IList<Product> GetProducts();
        bool IsRealProductId(int input);
        Product GetProductById(int input);
    }
}
