﻿using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Data;
using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Service;
using System;

namespace KramDeliverFoodCompleted
{
    class Program
    {
        static void Main(string[] args)
        {
            Messager.ShowWelcomeMessage();
            var serializerService = new SerializerService();
            var data = new StoreContext(serializerService);
            data.InitProducts();
            var reader = new Reader();
            var checker = new CheckerService();
            var loggerService = new LoggerService();
            var currencyExchangeService = new CurrerncyExchangeService();
            var orderService = new OrderService(data, checker, loggerService, currencyExchangeService);
            var cache = new Cache();
            var cacheService = new CacheService(cache);
            var productService = new ProductService(data, loggerService, serializerService, cacheService);
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

            Messager.ShowByeMessage();
            Console.ReadKey();
        }
    }
}
