using KramDeliveryFood_v3.Models;
using KramDeliveryFood_v3.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace KramDeliveryFood_v3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = Initialize();
            var repository = new Repository(configuration.GetConnectionString("DefaultConnection"));
            //var repositoryContrib = new RepoContrib(configuration.GetConnectionString("DefaultConnection"));

            Console.WriteLine("---Task 1---");
            var t1_product = repository.GetProductById(Guid.Parse("4b0b95d6-f272-47b1-80da-28711621dfa9"));
            //var providerContrib = repositoryContrib.GetProviderById(Guid.Parse("F08E1482-6C5D-4E8A-AE78-01417E19BEF8"));
            Console.WriteLine($"{t1_product.ProductID}, {t1_product.Name}");

            Console.WriteLine("---Task 2---");
            var t2_product = repository.GetCategoryWithProductsById(Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            //var providerContrib = repositoryContrib.GetProviderById(Guid.Parse("F08E1482-6C5D-4E8A-AE78-01417E19BEF8"));
            Console.WriteLine($"{t2_product.CategoryName}, {t2_product.ProductID}, {t2_product.Name}");

            Console.WriteLine("---Task 3---");
            var t3_product = repository.GetProducts();
            //var providerContrib = repositoryContrib.GetProviderById(Guid.Parse("F08E1482-6C5D-4E8A-AE78-01417E19BEF8"));
            foreach(var product in t3_product)
            {
                Console.WriteLine($"{product.ProductID}, {product.Name}");
            }

            Console.WriteLine("---Task 4---");
            var t4_product = repository.GetCategoryWithProductsById(Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            //var providerContrib = repositoryContrib.GetProviderById(Guid.Parse("F08E1482-6C5D-4E8A-AE78-01417E19BEF8"));
            Console.WriteLine($"{t2_product.CategoryName}, {t2_product.ProductID}, {t2_product.Name}");

            Console.ReadKey();
        }

        private static IConfiguration Initialize()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
