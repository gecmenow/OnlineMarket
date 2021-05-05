using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interaction
{
    public class ProviderReader
    {
        string ProductField()
        {
            var product = String.Empty;

            while (!Checker.EmptyUserInput(product))
                product = Console.ReadLine();

            return product;
        }

        public Product InputProductFields()
        {
            var product = new Product();

            var productNamespaces = product.GetProductsNamesapaces();

            var inputProductData = new List<string>();

            foreach (var prdct in productNamespaces)
            {
                var temp = prdct + " = ";
                Console.Write(temp);
                inputProductData.Add(ProductField());
            }

            product.Id = new Guid();
            product.Name = inputProductData[0];
            product.Price = Convert.ToDecimal(inputProductData[1]);
            product.Specifications = inputProductData[2];
            product.Description = inputProductData[3];

            return product;
        }
    }
}
