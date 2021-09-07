using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KramDeliverFoodCompleted.Services
{
    public class OrderService : IOrderService
    {
        private readonly IData _data;
        private readonly ILoggerService _loggerService;

        public OrderService(IData data, ILoggerService loggerService)
        {
            _data = data;
            _data.Orders = new List<Order>();
            _data.Order = new Order();
            _loggerService = loggerService;
        }

        public void AddProductToOrder(Product product)
        {
            _data.Order.OrderProducts.Add(product);
            _loggerService.AddLog("Product was added to order " + product.Id);
        }

        public Order GetOrder()
        {
            return _data.Order;
        }

        public IList<Order> GetOrders()
        {
            return _data.Orders;
        }

        public bool IsPhoneValid(string input)
        {
            if (checkPhone(input))
            {
                _data.Order.PhoneNumber = input;

                return true;
            }

            return false;
        }

        public bool IsAddressValid(string input)
        {
            if (checkAddress(input))
            {
                _data.Order.Address = input;

                return true;
            }

            return false;
        }

        public void CompleteOrder(Order order)
        {
            _data.Orders.Add(order);
        }
        private bool checkPhone(string number)
        {
            var pattern = @"^(\+380|0)(\(\d{2}\)|\d{2})\s?\d{3}\s?\d{2}\s?\d{2}$";
            var expression = new Regex(pattern);
            var isMatch = expression.IsMatch(number);

            return isMatch;
        }

        private bool checkAddress(string address)
        {
            var pattern = @"(^([а-я]{5}|[а-я]{2})\s?(.|\s{1})\s?([А-Я][а-я]{9}|[А-Я][а-я]{4})(,|.)\s?([а-я]|[а-я]{3})(.|\s{1})\s?\d{2})|(,\s?([а-я]{2}|[а-я]{8})(.|\s{1})\s?\d{2})$";
            var expression = new Regex(pattern);
            var isMatch = expression.IsMatch(address);

            return isMatch;
        }
    }
}
