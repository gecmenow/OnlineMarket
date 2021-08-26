using KramDelivery.Domain.Interfaces;
using KramDelivery.Domain.Models;
using System.Collections.Generic;

namespace KramDelivery.Domain.Service
{
    public class ProductService : IProductService
    {
        private IData _data;
        public ProductService(IData data)
        {
            _data = data;
        }

        public IList<Product> GetProducts()
        {
            return _data.BaseProducts;
        }
    }
}
