using KramDeliverFoodCompleted.Service;
using System;

namespace KramDeliverFoodCompleted.Interaction
{
    public class BuyerInteraction
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;

        public BuyerInteraction(ProductService productService, OrderService orderService)
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

            while (!_orderService.IsPhoneValid(Console.ReadLine()))
            {
                BuyerMessenger.ShowRepeatData();
            }

            BuyerMessenger.ShowAddAddressMessage();

            while (!_orderService.IsAddressValid(Console.ReadLine()))
            {
                BuyerMessenger.ShowRepeatData();
            }

            var order = _orderService.GetOrder();
            _orderService.CompleteOrder(order);
            Messenger.ShowCurrencies();
            var currency = ReadInputData();
            _orderService.GetSummary(currency);
            var orders = _orderService.GetOrders();
            BuyerMessenger.ShowBuyerOrders(orders);
            _orderService.ClearOrders();
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