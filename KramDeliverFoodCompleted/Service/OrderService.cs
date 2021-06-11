using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        private readonly IData _data;
<<<<<<< HEAD
        private readonly ICheckerService _checker;
        private readonly ILoggerService _loggerService;

        public OrderService(IData data, ICheckerService checker, ILoggerService loggerService)
=======

        public OrderService(IData data)
>>>>>>> main
        {
            _data = data;
            _data.Orders = new List<Order>();
            _data.Order = new Order();
<<<<<<< HEAD
            _checker = checker;
            _loggerService = loggerService;
=======
>>>>>>> main
        }

        public void AddProductToOrder(Product product)
        {
            _data.Order.OrderProducts.Add(product);
<<<<<<< HEAD
            _loggerService.AddLog("Product was added to order " + product.Id);
=======
>>>>>>> main
        }

        public Order GetOrder()
        {
            return _data.Order;
        }

        public IList<Order> GetOrders()
        {
            return _data.Orders;
        }

<<<<<<< HEAD
        public bool IsPhoneValid(string input)
        {
            if (_checker.CheckPhone(input))
            {
                _data.Order.PhoneNumber = input;

                return true;
            }

            return false;
        }

        public bool IsAddressValid(string input)
        {
            if (_checker.CheckAddress(input))
            {
                _data.Order.Address = input;

                return true;
            }

            return false;
=======
        public bool SetPhoneNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            _data.Order.PhoneNumber = number;
            return true;
        }

        public bool SetAddressNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            _data.Order.Address = number;
            return true;
>>>>>>> main
        }

        public void CompleteOrder(Order order)
        {
            _data.Orders.Add(order);
        }
    }
}
