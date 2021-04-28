using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Logs;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Buyer : BaseBuyer
    {
        public new void Order()
        {
            var product = new Product();

            UserMessage.Products(product.GetProducts());
            UserMessage.BuyInstruction();

            while (true)
            {
                var input = InputReader.UserChoice();

                while (!Checker.RealProductId(input))
                    input = InputReader.UserChoice();

                product = product.GetProduct(input);

                product.AddProductToOrder(product);

                if (!InputReader.BuyMoreProducts())
                    break;

                UserMessage.BuyInstruction();
            }

            UserMessage.UserInformation();

            var userInfo = InputReader.UserInformation();

            var orderedProducts = product.GetOrderedProducts();

            Checkout(orderedProducts, userInfo);
        }

        void Checkout(IEnumerable<Product> products, string information)
        {
            var checkout = new Checkout();

            checkout.Order = products;
            checkout.Information = information;

            UserMessage.Order(checkout, information);

            UserMessage.SuccessfulOrder();
        }
    }
}
