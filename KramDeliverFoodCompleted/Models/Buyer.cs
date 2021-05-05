using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Interaction;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Buyer : BaseBuyer
    {
        public new void Order()
        {
            var product = new Product();

            BuyerMessage.Products(product.GetProducts());
            BuyerMessage.BuyInstruction();

            while (true)
            {
                var input = BuyerReader.UserChoice();

                while (!Checker.RealProductId(input))
                    input = BuyerReader.UserChoice();

                product = product.GetProduct(input);

                product.AddProductToOrder(product);

                if (!BuyerReader.BuyMoreProducts())
                    break;

                BuyerMessage.BuyInstruction();
            }

            BuyerMessage.BuyerPhone();

            var phoneNumber = BuyerReader.PhoneNumber();

            BuyerMessage.BuyerAddress();

            var address = BuyerReader.Address();

            var orderedProducts = product.GetOrderedProducts();

            Checkout(orderedProducts, phoneNumber, address);
        }

        void Checkout(IEnumerable<Product> products, string phoneNumber, string address)
        {
            var checkout = new Checkout();

            checkout.Order = products;
            checkout.Address = address;
            checkout.PhoneNumber = phoneNumber;

            BuyerMessage.Order(checkout, address, phoneNumber);

            BuyerMessage.SuccessfulOrder();
        }
    }
}
