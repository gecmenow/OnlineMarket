using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliveryFood.Structure.Interfaces.Repositories
{
    public interface IProductRepository
    {
        IList<Product> GetAllProducts();

        IList<Product> GetProductsByCategoryName(string category);

        Product GetProductById(Guid id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void RemoveProduct(Product product);
    }
}
