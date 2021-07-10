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
            BuyerMessager.ShowProducts(_productService.GetProducts());
            BuyerMessager.BuyInstruction();

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

            BuyerMessager.BuyerPhone();

            while(!_orderService.SetPhoneNumber(Console.ReadLine()))
            {
                BuyerMessager.RepeatData();
            }

            BuyerMessager.BuyerAddress();

            while (!_orderService.SetAddressNumber(Console.ReadLine()))
            {
                BuyerMessager.RepeatData();
            }

            var order = _orderService.GetOrder();
            _orderService.CompleteOrder(order);
            Messager.ShowCurrencies();
            var currency = ReadInputData();
            _orderService.GetSummary(currency);
            var orders = _orderService.GetOrders();
            BuyerMessager.ShowOrder(orders);
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
                        Messager.RepeatInput();
                        continue;
                    }

                    break;
                }
            }

            return result;
        }
    }
}
