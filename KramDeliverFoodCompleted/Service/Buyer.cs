using KramDeliverFoodCompleted;
using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Service
{
    public class Buyer
    {
        private readonly BuyerReader _buyerReader;
        private readonly Product _product;
        private readonly Order _order;

        public Buyer(BuyerReader buyerReader, Product product, Order order)
        {
            _buyerReader = buyerReader;
            _product = product;
            _order = order;
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

                _order.AddProductToOrder(input);

                if (!BuyerReader.BuyMoreProducts())
                    break;

                BuyerMessager.BuyInstruction();
            }
        } 

        public void MakeCheckout()
        {
            BuyerMessager.BuyerPhone();

            var phoneNumber = BuyerReader.EnterPhoneNumber();

            BuyerMessager.BuyerAddress();

            var address = BuyerReader.EnterAddress();

            var orderedProducts = _order.GetOrderedProducts();

            _order.MakeCheckout(orderedProducts, phoneNumber, address);
        }
    }
}
