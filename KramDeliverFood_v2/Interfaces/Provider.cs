using KramDeliverFoodCompleted.Logs;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public class Provider
    {
        public void AddProduct()
        {
            ProviderMessage.AddProduct();

            var providerReader = new ProviderReader();

            var newProduct = providerReader.InputProductFields();

            var product = new Product();
            product.AddProduct(newProduct);
        }
    }
}
