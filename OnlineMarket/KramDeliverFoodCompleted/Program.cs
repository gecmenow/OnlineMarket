﻿using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Service;
using System;

namespace KramDeliverFoodCompleted
{    
    public class Program
    {
        private static void Main(string[] args)
        {
            Messenger.ShowWelcomeMessage();
            var serializerService = new SerializerService();
            var data = new StoreContext();
            data.InitProducts();
            var reader = new Reader();
            var loggerService = new LoggerService();
            var orderService = new OrderService(data, loggerService);
            var productService = new ProductService(data, loggerService, serializerService);
            var userInteraction = new BuyerInteraction(productService, orderService);
            var providerInteraction = new ProviderInteraction(productService);
            var isRunning = true;

            while (isRunning)
            {
                var choice = reader.MakeInput();

                switch (choice)
                {
                    case 1:
                        userInteraction.MakeOrder();
                        break;
                    case 2:
                        providerInteraction.AddProduct();
                        break;
                    case 3:
                        isRunning = false;
                        break;
                }
            }

            Messenger.ShowByeMessage();
            Console.ReadKey();
        }
    }
}
