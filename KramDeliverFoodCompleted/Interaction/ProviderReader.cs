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

        public Product InputProductFields()
        {
            var productNamespaces = _product.GetProductsNamespaces();

            var inputProductData = new List<string>();

            foreach (var prdct in productNamespaces)
            {
                var temp = prdct + " = ";
                Console.Write(temp);
                inputProductData.Add(ProductField());
            }

            _product.Id = new Guid();
            _product.Name = inputProductData[0];
            _product.Price = Convert.ToDecimal(inputProductData[1]);
            _product.Specifications = inputProductData[2];
            _product.Description = inputProductData[3];

            return _product;
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
