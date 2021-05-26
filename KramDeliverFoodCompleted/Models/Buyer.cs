﻿using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Interaction;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Buyer : BaseBuyer
    {
        private readonly BuyerReader _buyerReader;
        private readonly Checker _checker;
        private readonly Product _product;
        private readonly Checkout _checkout;

        public Buyer(BuyerReader buyerReader, Checker checker, Product product, Checkout checkout)
        {
            _buyerReader = buyerReader;
            _checker = checker;
            _product = product;
            _checkout = checkout;
        }
    
        public void MakeOrder()
        {
            BuyerMessage.ShowProducts(_product.GetProducts());
            BuyerMessage.BuyInstruction();

            while (true)
            {
                var input = _buyerReader.MakeInput();

                while (!_checker.IsRealProductId(input))
                    input = _buyerReader.MakeInput();

                var enteredProduct = _product.GetProduct(input);

                _product.AddProductToOrder(_product);

                if (!BuyerReader.BuyMoreProducts())
                    break;

                BuyerMessage.BuyInstruction();
            }

            BuyerMessage.BuyerPhone();

            var phoneNumber = BuyerReader.EnterPhoneNumber();

            BuyerMessage.BuyerAddress();

            var address = BuyerReader.EnterAddress();

            var orderedProducts = _product.GetOrderedProducts();

            Checkout(orderedProducts, phoneNumber, address);
        }

        void Checkout(IEnumerable<Product> products, string phoneNumber, string address)
        {
            _checkout.Order = products;
            _checkout.Address = address;
            _checkout.PhoneNumber = phoneNumber;

            BuyerMessage.MakeOrder(_checkout, address, phoneNumber);

            BuyerMessage.ShowSuccessfulOrder();
        }
    }
}
