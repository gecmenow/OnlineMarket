using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Interaction;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Buyer : BaseBuyer
    {
        private Reporter _reporter;

        private Product _product;

        private Checkout _checkout;

        public Buyer(Product product, Reporter reporter, Checkout checkout)
        {
            _product = product;
            _reporter = reporter;
            _checkout = checkout;
        }

        public new void Order()
        {
            BuyerMessage.Products(_product.GetProducts());
            BuyerMessage.BuyInstruction();

            while (true)
            {
                var input = BuyerReader.UserChoice();

                while (!Checker.RealProductId(input))
                    input = BuyerReader.UserChoice();

                _product = _product.GetProduct(input);

                _product.AddProductToOrder(_product);

                _reporter.OrderedProduct(_product);

                if (!BuyerReader.BuyMoreProducts())
                    break;

                BuyerMessage.BuyInstruction();
            }

            BuyerMessage.BuyerPhone();

            var phoneNumber = BuyerReader.PhoneNumber();

            BuyerMessage.BuyerAddress();

            var address = BuyerReader.Address();

            var orderedProducts = _product.GetOrderedProducts();

            Checkout(orderedProducts, phoneNumber, address);
        }

        void Checkout(IEnumerable<Product> products, string phoneNumber, string address)
        {
            _checkout.Order = products;
            _checkout.Address = address;
            _checkout.PhoneNumber = phoneNumber;

            BuyerMessage.Order(_checkout, address, phoneNumber);

            BuyerMessage.SuccessfulOrder();
        }
    }
}
