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
            BuyerMessanger.ShowBuyerProducts(_productService.GetProducts());
            BuyerMessanger.ShowBuyInstruction();

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

            BuyerMessanger.ShowAddPhoneMessage();

            while (!_orderService.SetPhoneNumber(Console.ReadLine()))
            {
                BuyerMessanger.ShowWrongInputMessage();
            } 

            BuyerMessanger.ShowAddAddressMessage();
            
            while (!_orderService.SetAddressNumber(Console.ReadLine()))
            {
                BuyerMessanger.ShowWrongInputMessage();
            }

            var order = _orderService.GetOrder();
            _orderService.CompleteOrder(order);

            var orders = _orderService.GetOrders();
            BuyerMessanger.ShowBuyerOrders(orders);
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
                        Messanger.RepeatInput();
                        continue;
                    }

                    break;
                }
            }

            return result;
        }
    }
}
