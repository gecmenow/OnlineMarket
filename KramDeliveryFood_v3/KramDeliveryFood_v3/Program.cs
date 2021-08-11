using KramDelivery.Domain.Models;
using KramDelivery.Domain.Service;
using KramDeliveryFood.Data;
using System;
using System.IO;
using System.Linq;

namespace KramDeliveryFood_v3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork();
            var products = unitOfWork.Products.GetAllWithTracking();
            var productTest = products.FirstOrDefault();
            productTest.Name = "test";
            
            //unitOfWork.Products.UpdateProduct(productTest);
            unitOfWork.Save();

            var productsByAlphabet = products.OrderBy(p => p.Name).ToList();
            Console.WriteLine("---Task 1 ---\n");

            foreach (var product in productsByAlphabet)
            {
                Console.WriteLine(product.Name);
            }

            var productsWithProvider = products.Select(p => new { ProviderName = p.Provider.Name, ProcutName = p.Name }).ToList();
            Console.WriteLine("\n---Task 2 ---\n");

            foreach (var product in productsWithProvider)
            {
                Console.WriteLine(product.ProviderName + " - " + product.ProcutName);
            }

            var categoryProductsCount = products.GroupBy(p => p.CategoryId).Select(c => new { CategoryName = c.Select(c => c.Categorie.Name).FirstOrDefault(), CategoryCount = c.Count() }).ToList();
            Console.WriteLine("\n---Task 3 ---\n");

            foreach (var category in categoryProductsCount)
            {
                Console.WriteLine(category.CategoryName + " - " + category.CategoryCount);
            }

            var providerProductDesc = products.GroupBy(p => p.ProviderId).Select(p => new { ProviderName = p.Select(p => p.Provider.Name).FirstOrDefault(), ProductsCount = p.Count() }).OrderByDescending(p => p.ProductsCount).ToList();
            Console.WriteLine("\n---Task 4 ---\n");

            foreach (var product in providerProductDesc)
            {
                Console.WriteLine(product.ProviderName + " - " + product.ProductsCount);
            }

            var productsJhon = products.Where(provider => provider.ProviderId == Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4")).ToList();
            var productsTomas = products.Where(provider => provider.ProviderId == Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024")).ToList();
            var commonProducts = productsJhon.Intersect(productsJhon, new ProductComparer()).ToList();
            Console.WriteLine("\n---Task 5.1---\n");

            foreach (var common in commonProducts)
            {
                Console.WriteLine(common.Name + " " + common.ProductType);
            }

            var variousProductsJhon = productsJhon.Except(productsTomas, new ProductComparer()).ToList();
            var variousProductsTomas = productsTomas.Except(productsJhon, new ProductComparer()).ToList();
            var variousProducts = variousProductsJhon.Concat(variousProductsTomas).ToList();
            Console.WriteLine("\n---Task 5.2---\n");

            foreach (var various in variousProducts)
            {
                Console.WriteLine(various.ProviderId + " " + various.Name);
            }

            Console.ReadKey();
        }
    }
}
