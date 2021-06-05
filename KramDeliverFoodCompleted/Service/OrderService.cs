using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IList<Product> OrderProducts { get; set; }
        private readonly IData _data;
        private readonly ICheckerService _checker;
        private readonly ILoggerService _loggerService;

        public OrderService(IData data, ICheckerService checker, ILoggerService loggerService)
        {
            _data = data;
            _checker = checker;
            _loggerService = loggerService;
            _data.Order = new Order();
        }

        public void AddProductToOrder(Product product)
        {
            _data.Order.OrderProducts.Add(product);
            _loggerService.AddLog("Product was added to order " + product.Id);
        }

        public IList<Product> GetOrderedProducts()
        {
            return _data.Order.OrderProducts;
        }

        public bool SetPhoneNumber(string input)
        {
            var valid = _checker.CheckPhone(input);

            if (valid)
            {
                PhoneNumber = input;
            }

            return valid;
        }

        public bool SetAddress(string input)
        {
            var valid = _checker.CheckAddress(input);

            if (valid)
            {
                Address = input;
            }

            return valid;
        }
    }
}
