using KramDeliverFoodCompleted.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Models
{
    public class Provider
    {
        public void AddProduct()
        {
            var provider = new ProviderReader();

            var newProduct = provider.InputProductFields();

            var product = new Product();
            product.AddProduct(newProduct);

            ProviderMessage.ProductAdded();
        }
    }
}
