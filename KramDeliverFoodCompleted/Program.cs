using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
<<<<<<< HEAD
=======
using KramDeliverFoodCompleted.Service;
>>>>>>> task_3
using System;

namespace KramDeliverFoodCompleted
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var flag = true;

            while (flag)
            {
                Logger.WelcomeMessage();

                Buyer buyer = new Buyer();
            
                var choice = BuyerReader.UserChoice();

                var product = new Product();

                var provider = new Provider();
=======
            Messager.ShowWelcomeMessage();
            var data = new StoreContext();
            data.InitProducts();
            var reader = new Reader();
            var orderService = new OrderService(data);
            var productService = new ProductService(data);
            var userInteraction = new BuyerInteraction(productService, orderService);
            var providerInteraction = new ProviderInteraction(productService);
            var isRunning = true;

            while (isRunning)
            {
                var choice = reader.MakeInput();
>>>>>>> task_3

                switch (choice)
                {
                    case 1:
<<<<<<< HEAD
                        product.InitProducts();
                        buyer.Order();
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

            Logger.ByeMessage();

=======
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
>>>>>>> task_3
            Console.ReadKey();
        }
    }
}
