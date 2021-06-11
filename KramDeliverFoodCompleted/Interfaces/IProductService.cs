using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IProductService
    {
<<<<<<< HEAD
        public void AddProduct(Product product);
        public IList<Product> GetProducts();
=======
        void AddProduct(Product product);

        IList<Product> GetProducts();
>>>>>>> main
        bool IsRealProductId(int input);
        Product GetProductById(int input);
    }
}
