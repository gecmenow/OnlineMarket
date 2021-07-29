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
            var products = storeContext.BaseProducts;
            var productsAsc = products.OrderBy(p => p.Name);

            Console.WriteLine("---Task 1---");

            foreach(var product in productsAsc)
            {
                Console.WriteLine(product.Id + " " + product.Name);
            }

            var providers = storeContext.Providers;
            var productsWithProviders = products.Join(providers,
                pr => pr.ProviderId,
                prov => prov.ProdviderId,
                (pr, prov) => new { Provider = prov.Name, Name = pr.Name });

            Console.WriteLine("---Task 2---");

            foreach (var provProducts in productsWithProviders)
            {
                Console.WriteLine(provProducts.Provider + " " + provProducts.Name);
            }

            var categories = storeContext.Categories;
            var categoriesProducts = categories.Join(products,
                cat => cat.CategoryId,
                pr => pr.CategoryId,
                (cat, pr) => new { CategoryId = cat.CategoryId, Category = cat.Name })
                .GroupBy(cat => cat.CategoryId)
                .Select(cat => new
                {
                    CategoryName = cat.Select(c=>c.Category).FirstOrDefault(),
                    CategoryCount = cat.Count(),
                });

            Console.WriteLine("---Task 3---");

            foreach (var category in categoriesProducts)
            {
                Console.WriteLine(category.CategoryName + " " + category.CategoryCount);
            }

            var providersProductsDesc = products.Join(providers,
                pr => pr.ProviderId,
                prov => prov.ProdviderId,
                (pr, prov) => new { ProviderId = prov.ProdviderId, Provider = prov.Name})
                .GroupBy(prov => prov.ProviderId)
                .Select(prov => new
                {
                    ProviderName = prov.Select(prov=>prov.Provider).FirstOrDefault(),
                    ProductsCount = prov.Count(),
                })
                .OrderByDescending(prov => prov.ProductsCount);

            Console.WriteLine("---Task 4---");

            foreach (var provider in providersProductsDesc)
            {
                Console.WriteLine(provider.ProviderName + " " + provider.ProductsCount);
            }

            var providerJhon = products.Where(provider => provider.ProviderId == Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4")).ToList();
            var providerTomas = products.Where(provider => provider.ProviderId == Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024")).ToList();

            //var providerJhon = products.Join(providers,
            //    pr => pr.ProviderId,
            //    prov => prov.ProdviderId,
            //    (pr, prov) => new Products { ProviderId = prov.ProdviderId, Name = pr.Name, CategoryId = pr.CategoryId, ProductType = pr.ProductType }).ToList()
            //    .Where(prov => prov.ProviderId == Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4")).ToList();

            //var providerTomas = products.Join(providers,
            //    pr => pr.ProviderId,
            //    prov => prov.ProdviderId,
            //    (pr, prov) => new Products { ProviderId = prov.ProdviderId, Name = pr.Name, CategoryId = pr.CategoryId, ProductType = pr.ProductType }).ToList()
            //    .Where(prov => prov.ProviderId == Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024")).ToList();

            var commonProducts = providerTomas.Intersect(providerJhon, new ProductsComparer()).ToList();

            //var commonProducts = providerJhon.Join(providerTomas,
            //    prJ => prJ.ProductType,
            //    prT => prT.ProductType,
            //    (prJ, prT) => new { ProviderJhon = prJ.ProviderId, ProviderTomas = prT.ProviderId, Product = prJ.ProductType});

            Console.WriteLine("---Task 5.1---");

            foreach (var common in commonProducts)
            {
                Console.WriteLine(common.Id + " " + common.Name + " " + common.ProductType);
            }

            var variousProducts = providerJhon.Except(providerTomas, new ProductsComparer()).ToList();

            Console.WriteLine("---Task 5.2---");

            foreach (var various in variousProducts)
            {
                Console.WriteLine(various.ProviderId + " " + various.Name);
            }

            Console.ReadKey();
        }
    }
}
