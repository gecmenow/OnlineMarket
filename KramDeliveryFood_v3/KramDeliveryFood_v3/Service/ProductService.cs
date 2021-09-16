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

        public ProductService(IData data)
        {
            _data = data;
        }
        public IList<Product> GetAllPRoducts()
        {
            _products = _data.BaseProducts;

            return _products;
        }

        public IList<Product> GetProductsAsc()
        {
            return _products.OrderBy(p=>p.Name).ToList();
        }

        public IList<(string Provider, string Product)> GetProductsWithProviders()
        {
            var productsWithProviders = _products.Select(p => new { Provider = p.Name, Product = p.Provider.Name }).Select(r => (r.Product, r.Provider)).ToList();

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

        public IList<Tuple<string, int>> GetProvidersProductsDesc()
        {
            var providersProductsDesc = _products.GroupBy(p=>p.Provider).Select(p => new Tuple<string, int>(p.Key.Name, p.Count()))
                .OrderByDescending(p => p.Item2).ToList();

            return providersProductsDesc;
        }

        public (IList<Product>, IList<Product>) GetGrouppedProducts(Guid firstProvider, Guid secondProvider)
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
