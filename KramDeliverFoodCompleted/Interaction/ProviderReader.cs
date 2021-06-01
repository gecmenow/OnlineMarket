using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderReader
    {
        private readonly Product _product;
        public ProviderReader(Product product)
        {
            _product = product;
        }

        public List<string> InputProductFields()
        {
            var productNamespaces = _product.GetProductsNamespaces();

            var inputProductData = new List<string>();

            foreach (var product in productNamespaces)
            {
                ProviderMessager.ShowInputProductField(product);
                inputProductData.Add(ProductField());
            }

            return inputProductData;
        }

        string ProductField()
        {
            var product = string.Empty;

            while (string.IsNullOrEmpty(product))
                product = Console.ReadLine();

            return product;
        }
    }
}
