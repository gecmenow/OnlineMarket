using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Service;
using System;

namespace KramDeliverFoodCompleted
{
    class Program
    {
        static void Main(string[] args)
        {
            var isRunning = true;

            while (isRunning)
            {
                Messager.ShowWelcomeMessage();

                var productSaver = new ProductSaver();

                var product = new Service.Product();

                var productModel = new Models.Product();

                var buyerReader = new BuyerReader(product);

                var checkout = new Checkout();

                var order = new Order(product, productSaver, checkout);

                var buyer = new Buyer(buyerReader, product, order);

                var reader = new Reader();
            
                var choice = reader.MakeInput();

                var providerReader = new ProviderReader(product);

                var provider = new Provider(productModel, product, providerReader);

                var storeContext = new StoreContext(product);

                switch (choice)
                {
                    case 1:
                        storeContext.InitProducts();
                        buyer.MakeOrder();
                        buyer.MakeCheckout();
                        break;
                    case 2:
                        storeContext.InitProducts();
                        provider.AddProduct();
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
