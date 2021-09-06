using KramDeliverFoodCompleted.Data;
using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Service;
using System;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted
{    
    public class Program
    {
        private static async Task Main(string[] args)
        {
            Messenger.ShowWelcomeMessage();
            var serializerService = new SerializerService();
            var data = new StoreContext(serializerService);
            data.InitProducts();
            var reader = new Reader();
            var loggerService = new LoggerService();
            var currencyExchangeService = new CurrerncyExchangeService();
            var orderService = new OrderService(data, loggerService, currencyExchangeService);
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
                        await userInteraction.MakeOrder();
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
