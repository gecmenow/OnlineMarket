using KramDeliverFood_v2.Interfaces;
using KramDeliverFood_v2.Logs;
using KramDeliverFood_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KramDeliverFood_v2
{
    public class Buyer : IBuyer
    {
        public Guid Id { get; set; }
        public IEnumerable<string> Products { get; set; }
        public string Information { get; set; }

        public void Order()
        {
            var product = new Product();

            UserMessage.Products(product.Products);

            InputReader.UserOrder();

            //TODO checkout
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
