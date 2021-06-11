﻿using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        private readonly IData _data;
        private readonly ICheckerService _checker;

        public OrderService(IData data, ICheckerService checker)
        {
            _data = data;
            _data.Orders = new List<Order>();
            _data.Order = new Order();
            _checker = checker;
        }

        public void AddProductToOrder(Product product)
        {
            _data.Order.OrderProducts.Add(product);
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
        }

        public void CompleteOrder(Order order)
        {
            _data.Orders.Add(order);
        }
    }
}
