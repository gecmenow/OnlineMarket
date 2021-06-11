using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        void AddProductToOrder(Product product);
        IList<Order> GetOrders();
        Order GetOrder();
        bool IsPhoneValid(string number);
        bool IsAddressValid(string number);
        void CompleteOrder(Order order);
    }
}
