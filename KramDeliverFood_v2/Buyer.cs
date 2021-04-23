using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFood_v2
{
    public class Buyer : IBuyer
    {
        public Guid Id { get; set; }
        public IEnumerable<string> Products { get; set; }
        public string Information { get; set; }

        public IEnumerable<string> Order(string prodcuts)
        {
            Products = Products.Append(prodcuts);

            return Products;
        }

        public Checkout Checkout(IEnumerable<string> products, string information)
        {
            var checkout = new Checkout();

            checkout.Order = products;
            checkout.Information = information;

            return checkout;
        }
    }
}
