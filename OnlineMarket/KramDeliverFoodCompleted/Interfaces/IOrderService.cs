using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        Orders GetOrder();
        bool IsPhoneValid(string number);
        bool IsAddressValid(string number);
        void AddProductToOrder(Products product);
        IList<Orders> GetOrders();
        void CompleteOrder(Orders order);
    }
}
