using KramDeliverFoodCompleted.Interaction;
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

                var product = new Product();

                var reporter = new Reporter();

                var buyer = new Buyer(product, reporter);
            
                var choice = BuyerReader.UserChoice();

                var providerReader = new ProviderReader();

                var provider = new Provider(providerReader, product, reporter);

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
