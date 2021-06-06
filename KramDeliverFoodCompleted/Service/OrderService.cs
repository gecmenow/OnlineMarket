﻿using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        private readonly IData _data;

        public OrderService(IData data)
        {
            _data = data;
            _data.Orders = new List<Order>();
            _data.Order = new Order();
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
        }

        public void CompleteOrder(Order order)
        {
            _data.Orders.Add(order);
        }
    }
}
