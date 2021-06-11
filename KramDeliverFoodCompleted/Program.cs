<<<<<<< HEAD
﻿using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interaction;
=======
﻿using KramDeliverFoodCompleted.Interaction;
>>>>>>> main
using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Service;
using System;

namespace KramDeliverFoodCompleted
{
<<<<<<< HEAD
    class Program
    {
        static void Main(string[] args)
=======
    public class Program
    {
        private static void Main(string[] args)
>>>>>>> main
        {
            Messenger.ShowWelcomeMessage();
            var data = new StoreContext();
            data.InitProducts();
            var reader = new Reader();
<<<<<<< HEAD
            var checker = new CheckerService();
            var loggerService = new LoggerService();
            var orderService = new OrderService(data, checker, loggerService);
            var productService = new ProductService(data, loggerService);
=======
            var orderService = new OrderService(data);
            var productService = new ProductService(data);
>>>>>>> main
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
