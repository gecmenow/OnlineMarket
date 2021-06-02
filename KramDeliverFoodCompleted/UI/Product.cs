using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.UI
{
    public class Product
    {
        public IEnumerable<string> GetProductsNamespaces()
        {
            var productNamespaces = new List<string>();

            productNamespaces.Add("Name");
            productNamespaces.Add("Price");
            productNamespaces.Add("Specifications");
            productNamespaces.Add("Description");

            return productNamespaces;
        }
    }
}
