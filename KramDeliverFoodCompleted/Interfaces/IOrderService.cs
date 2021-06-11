﻿using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        public void AddProductToOrder(Product product);
        public IList<Order> GetOrders();
        Order GetOrder();
        void CompleteOrder(Order order);
        public bool SetPhoneNumber(string number);
        public bool SetAddressNumber(string number);
    }
}
