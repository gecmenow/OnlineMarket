using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IProductService
    {
        public void AddProduct(Product product);

        public IList<Product> GetProducts();
    }
}
