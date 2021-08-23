using KramDeliveryFood_v3.Models;
using KramDeliveryFood_v3.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using KramDeliveryFood_v3.Service;

namespace KramDeliveryFood_v3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = Initialize();
            var repository = new Repository(configuration.GetConnectionString("DefaultConnection"));
            var repositoryContrib = new RepositoryContrib(configuration.GetConnectionString("DefaultConnection"));

            Console.WriteLine("---Task 1---");
            var t1_product = repository.GetProductById(Guid.Parse("4F176A75-F45B-41FD-95B4-8EA1B1521889"));
            Console.WriteLine($"{t1_product.ProductId}, {t1_product.Name}");
            Console.WriteLine("--------------------------------");
            t1_product = repositoryContrib.GetProductById(Guid.Parse("4F176A75-F45B-41FD-95B4-8EA1B1521889"));
            Console.WriteLine($"{t1_product.ProductId}, {t1_product.Name}");


            Console.WriteLine("---Task 2---");
            var t2_product = repository.GetCategoryWithProductsById(Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            Console.WriteLine($"{t2_product.CategoryName}, {t2_product.ProductId}, {t2_product.Name}");
            Console.WriteLine("--------------------------------");
            t2_product = repositoryContrib.GetCategoryWithProductsById(Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            Console.WriteLine($"{t2_product.CategoryName}, {t2_product.ProductId}, {t2_product.Name}");

            Console.WriteLine("---Task 3---");
            var t3_product = repository.GetProducts();

            foreach (var product in t3_product)
            {
                Console.WriteLine($"{product.ProductId}, {product.Name}");
            }

            Console.WriteLine("--------------------------------");
            t3_product = repositoryContrib.GetProducts();

            foreach (var product in t3_product)
            {
                Console.WriteLine($"{product.ProductId}, {product.Name}");
            }

            Console.WriteLine("---Task 4---");
            var t4_product = repository.GetCategoryWithProductsById(Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            Console.WriteLine($"{t4_product.CategoryName}, {t4_product.ProductId}, {t4_product.Name}");
            Console.WriteLine("--------------------------------");
            t4_product = repositoryContrib.GetCategoryWithProductsById(Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            Console.WriteLine($"{t4_product.CategoryName}, {t4_product.ProductId}, {t4_product.Name}");

            var data = new StoreContext();
            data.InitProducts();
            Console.WriteLine("---Task 5---");
            repository.AddProduct(data.BaseProducts[0]);
            repositoryContrib.AddProduct(data.BaseProducts[0]);

            Console.WriteLine("---Task 6---");
            repository.AddProductByCategory(data.BaseProducts[1], Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            repositoryContrib.AddProductByCategory(data.BaseProducts[1], Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            Console.WriteLine("---Task 7---");
            repository.UpdateProduct(data.BaseProducts[0]);
            repositoryContrib.UpdateProduct(data.BaseProducts[0]);

            Console.WriteLine("---Task 8---");
            repository.UpdateProductByCategory(data.BaseProducts[0], Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            repositoryContrib.UpdateProductByCategory(data.BaseProducts[0], Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));

            Console.WriteLine("--Task 9---");
            repository.DeleteProduct(Guid.Parse("DB7FC833-BED5-4DAB-B220-DC54A769839B"));
            repositoryContrib.DeleteProduct(data.BaseProducts[0]);

            Console.WriteLine("--Task 10---");
            repository.DeleteProductByCategory(Guid.Parse("DB7FC833-BED5-4DAB-B220-DC54A769839B"), Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));
            repositoryContrib.DeleteProductByCategory(data.BaseProducts[0], Guid.Parse("caa70cb5-b151-4930-8e1f-bf9aef018762"));

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
