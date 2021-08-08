using KramDeliveryFood_v3.Interfaces;
using KramDeliveryFood_v3.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace KramDeliveryFood_v3.Service
{
    public class ProductService : IProductService
    {
        private IData _data;
        private IList<Product> _products;
        private IList<Provider> _providers;

        public ProductService(IData data)
        {
            _data = data;
        }
        public IList<Product> GetAllPRoducts()
        {
            _products = _data.BaseProducts;

            return _products;
        }

        public IList<(string Provider, string Product)> GetProductsWithProviders()
        {
            _providers = _data.Providers;
            var productsWithProviders = _products.Join(_providers,
                pr => pr.ProviderId,
                prov => prov.ProviderId,
                (pr, prov) => new { Provider = prov.Name, Name = pr.Name }).Select(r => (r.Name, r.Provider)).ToList();

            return productsWithProviders;
        }

        public IList<(string CategoryName, int CategoryCount)> GetCategoriesProducts()
        {
            var categories = _data.Categories;
            var categoriesProducts = categories.Join(_products,
            cat => cat.CategoryId,
            pr => pr.CategoryId,
            (cat, pr) => new { CategoryId = cat.CategoryId, Category = cat.Name })
            .GroupBy(cat => cat.CategoryId)
            .Select(cat => new
            {
                CategoryName = cat.Select(c => c.Category).FirstOrDefault(),
                CategoryCount = cat.Count(),
            }).Select(r => (r.CategoryName, r.CategoryCount)).ToList();

            return categoriesProducts;
        }

        public IList<(string ProviderName, int ProductsCount)> GetProvidersProductsDesc()
        {
            var providersProductsDesc = _products.Join(_providers,
                pr => pr.ProviderId,
                prov => prov.ProviderId,
                (pr, prov) => new { ProviderId = prov.ProviderId, Provider = prov.Name })
                .GroupBy(prov => prov.ProviderId)
                .Select(prov => new
                {
                    ProviderName = prov.Select(prov => prov.Provider).FirstOrDefault(),
                    ProductsCount = prov.Count(),
                })
                .OrderByDescending(prov => prov.ProductsCount).Select(r => (r.ProviderName, r.ProductsCount)).ToList();

            return providersProductsDesc;
        }

        public (IList<Product>, IList<Product>) GetCommonProducts(Guid firstProvider, Guid secondProvider)
        {
            var providerJhon = _products.Where(provider => provider.ProviderId == firstProvider).ToList();
            var providerTomas = _products.Where(provider => provider.ProviderId == secondProvider).ToList();
            var commonProducts = providerTomas.Intersect(providerJhon, new ProductsComparer()).ToList();

            var variousProductsJhon = providerJhon.Except(providerTomas, new ProductsComparer()).ToList();
            var variousProductsTomas = providerTomas.Except(providerJhon, new ProductsComparer()).ToList();
            var variousProducts = variousProductsJhon.Concat(variousProductsTomas).ToList();

            return (commonProducts, variousProducts);
        }
    }
}
