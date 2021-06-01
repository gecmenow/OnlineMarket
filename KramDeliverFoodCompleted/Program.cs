﻿using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
using System;

namespace KramDeliverFoodCompleted
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = true;

            while (flag)
            {
                Messager.ShowWelcomeMessage();

                var product = new Product();

                var buyerReader = new BuyerReader(product);

                var checkout = new Checkout();

                var buyer = new Buyer(buyerReader, product, checkout);

                var reader = new Reader();
            
                var choice = reader.MakeInput();

                var providerReader = new ProviderReader(product);

                var provider = new Provider(product, providerReader);

                switch (choice)
                {
                    case 1:
                        product.InitProducts();
                        buyer.MakeOrder();
                        break;
                    case 2:
                        product.InitProducts();
                        provider.AddProduct();
                        break;
                    case 3:
                        flag = false;
                        break;
                }                
            }

            Messager.ShowByeMessage();

            Console.ReadKey();
        }
    }
}
