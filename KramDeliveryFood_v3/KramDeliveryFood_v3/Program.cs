using KramDeliveryFood_v3.Models;
using KramDeliveryFood_v3.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KramDeliveryFood_v3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var storeContext = new StoreContext();
            storeContext.InitProducts();
            var productService = new ProductService(storeContext);
            var products = productService.GetAllPRoducts();
            var sortedProducts = products.OrderBy(p => p.Name);

            Console.WriteLine("---Task 1---");

            foreach(var product in sortedProducts)
            {
                Console.WriteLine(product.ProductId + " " + product.Name);
            }

            var productsWithProviders = productService.GetProductsWithProviders();

            Console.WriteLine("---Task 2---");

            foreach (var provProducts in productsWithProviders)
            {
                Console.WriteLine(provProducts.Provider + " " + provProducts.Product);
            }

            var categoriesProducts = productService.GetCategoriesProducts();

            Console.WriteLine("---Task 3---");

            foreach (var category in categoriesProducts)
            {
                Console.WriteLine(category.CategoryName + " " + category.CategoryCount);
            }

            var sortedProvidersProducts = productService.GetProvidersProductsDesc();

            Console.WriteLine("---Task 4---");

            foreach (var provider in sortedProvidersProducts)
            {
                Console.WriteLine(provider.ProviderName + " " + provider.ProductsCount);
            }

            var groupedProducts = productService.GetCommonProducts(
                Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4"), 
                Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024")
                );

            Console.WriteLine("---Task 5.1---");

            foreach (var common in groupedProducts.Item1)
            {
                Console.WriteLine(common.Name + " " + common.ProductType);
            }

            Console.WriteLine("---Task 5.2---");

            foreach (var various in groupedProducts.Item2)
            {
                Console.WriteLine(various.ProviderId + " " + various.Name);
            }

            Console.ReadKey();
        }
    }
}
