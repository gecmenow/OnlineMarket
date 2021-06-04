using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderInteraction
    {
        private readonly ProductService _productService;
        public ProviderInteraction(ProductService productService)
        {
            _productService = productService;
        }

        public void AddProduct()
        {
            var product = new Product();

            ProviderMessager.AddProduct();

            var productFields = typeof(Product).GetProperties();

            foreach (var productField in productFields)
            {
                ProviderMessager.ShowInputProductField(productField);

                if (productField.PropertyType.Name == "Guid")
                {
                    productField.SetValue(product, Guid.NewGuid());
                }
                else if(productField.PropertyType.Name == "Decimal")
                {
                    productField.SetValue(product, decimal.Parse(Console.ReadLine()));
                }
                else
                {
                    productField.SetValue(product, Console.ReadLine());
                }
            }

            _productService.AddProduct(product);

            ProviderMessager.ProductAdded();
        }
    }
}
