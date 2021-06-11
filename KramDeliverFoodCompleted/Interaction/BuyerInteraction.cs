using KramDeliverFoodCompleted.Interfaces;
using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerInteraction
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;

        public BuyerInteraction(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }

        public void MakeOrder()
        {
            BuyerMessenger.ShowBuyerProducts(_productService.GetProducts());
            BuyerMessenger.ShowBuyInstruction();

            while (true)
            {
                var input = ReadInputData();

                while (!_productService.IsRealProductId(input))
                {
                    input = ReadInputData();
                }

                var product = _productService.GetProductById(input); 
                _orderService.AddProductToOrder(product);

                if (!Reader.BuyMoreProducts())
                {
                    break;
                }
            }

            BuyerMessenger.ShowAddPhoneMessage();

            while (!_orderService.SetPhoneNumber(Console.ReadLine()))
            {
                BuyerMessenger.ShowWrongInputMessage();
            } 

            BuyerMessenger.ShowAddAddressMessage();
            
            while (!_orderService.SetAddressNumber(Console.ReadLine()))
            {
                BuyerMessenger.ShowWrongInputMessage();
            }

            var order = _orderService.GetOrder();
            _orderService.CompleteOrder(order);

            var orders = _orderService.GetOrders();
            BuyerMessenger.ShowBuyerOrders(orders);
        }  

        private int ReadInputData()
        {
            var result = 0;

            while (true)
            {
                var input = Console.ReadLine();
                var productsCount = _productService.GetProducts().Count;

                if (int.TryParse(input, out result))
                {
                    if (result < 0 && result >= productsCount)
                    {
                        Messenger.RepeatInput();
                        continue;
                    }

                    break;
                }
            }

            return result;
        }
    }
}
