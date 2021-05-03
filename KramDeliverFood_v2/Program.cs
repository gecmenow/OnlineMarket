using KramDeliverFoodCompleted.Logs;
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
                Logger.WelcomeMessage();

                Buyer buyer = new Buyer();
            
                var choice = BuyerReader.UserChoice();

                var product = new Product();

                var provider = new Provider();

                switch (choice)
                {
                    case 1:
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

            Console.ReadKey();
        }
    }
}
