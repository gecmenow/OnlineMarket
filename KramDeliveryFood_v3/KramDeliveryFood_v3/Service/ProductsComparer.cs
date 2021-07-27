using KramDeliveryFood_v3.Models;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Service
{
    public class ProductsComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product x, Product y)
        {
            return x.ProductType == y.ProductType;
        }

        public override int GetHashCode(Product products)
        {
            return products.GetHashCode();
        }
    }
}
