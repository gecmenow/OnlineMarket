using KramDeliverFoodCompleted.Check;
using KramDeliverFoodCompleted.Interaction;
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
            var data = new StoreContext();
            data.InitProducts();
            var reader = new Reader();
            var checker = new CheckerService();
            var orderService = new OrderService(data, checker);
            var productService = new ProductService(data);
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
