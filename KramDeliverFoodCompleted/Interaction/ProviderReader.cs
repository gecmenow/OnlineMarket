using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderReader
    {
        private readonly Product _product;
        private readonly UI.Product _productInfo;
        public ProviderReader(Product product, UI.Product productInfo)
        {
            _product = product;
            _productInfo = productInfo;
        }

        public List<string> InputProductFields()
        {
            var productNamespaces = _productInfo.GetProductsNamespaces();

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
