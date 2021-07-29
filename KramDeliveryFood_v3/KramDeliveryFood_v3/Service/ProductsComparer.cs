using KramDeliveryFood_v3.Models;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Service
{
    public class ProductsComparer : EqualityComparer<Products>
    {
        public override bool Equals(Products x, Products y)
        {
            return x?.ProductType == y?.ProductType;
        }

        public override int GetHashCode(Products products)
        {
            return products.ProductType.GetHashCode();
        }
    }
}
