using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Interaction;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Buyer : BaseBuyer
    {
        private readonly BuyerReader _buyerReader;
        private readonly Product _product;
        private readonly Checkout _checkout;

        public Buyer(BuyerReader buyerReader, Product product, Checkout checkout)
        {
            _buyerReader = buyerReader;
            _product = product;
            _checkout = checkout;
        }
    
        public void MakeOrder()
        {
            BuyerMessager.ShowProducts(_product.GetProducts());
            BuyerMessager.BuyInstruction();

            while (true)
            {
                var input = _buyerReader.MakeInput();

                while (!_product.IsRealProductId(input))
                    input = _buyerReader.MakeInput();

                var enteredProduct = _product.GetProduct(input);

                _product.AddProductToOrder(_product);

                if (!BuyerReader.BuyMoreProducts())
                    break;

                BuyerMessager.BuyInstruction();
            }

            BuyerMessager.BuyerPhone();

            var phoneNumber = BuyerReader.EnterPhoneNumber();

            BuyerMessager.BuyerAddress();

            var address = BuyerReader.EnterAddress();

            var orderedProducts = _product.GetOrderedProducts();

            Checkout(orderedProducts, phoneNumber, address);
        }

        void Checkout(IEnumerable<Product> products, string phoneNumber, string address)
        {
            _checkout.Order = products;
            _checkout.Address = address;
            _checkout.PhoneNumber = phoneNumber;

            BuyerMessager.MakeOrder(_checkout, address, phoneNumber);

            BuyerMessager.ShowSuccessfulOrder();
        }
    }
}
