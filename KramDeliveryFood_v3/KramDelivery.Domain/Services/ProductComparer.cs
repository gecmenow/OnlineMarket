using KramDelivery.Structure.Models;
using System.Collections.Generic;

namespace KramDelivery.Domain.Service
{   
    public class ProductComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product x, Product y)
        {
            return x?.ProductType == y?.ProductType;
        }

        public override int GetHashCode(Product obj)
        {
            return obj.ProductType.GetHashCode();
        }
    }
}
