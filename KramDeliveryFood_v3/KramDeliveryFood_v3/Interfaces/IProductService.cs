using KramDeliveryFood_v3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliveryFood_v3.Interfaces
{
    public interface IProductService
    {
        IList<Product> GetAllPRoducts();
        IList<(string Provider, string Product)> GetProductsWithProviders();
        IList<(string CategoryName, int CategoryCount)> GetCategoriesProducts();
        IList<(string ProviderName, int ProductsCount)> GetProvidersProductsDesc();
        (IList<Product>, IList<Product>) GetGrouppedProducts(Guid firstProvider, Guid secondProvider);
    }
}
