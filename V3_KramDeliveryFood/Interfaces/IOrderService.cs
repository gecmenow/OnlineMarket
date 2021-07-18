using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        Order GetOrder();
        bool IsPhoneValid(string number);
        bool IsAddressValid(string number);
        void AddProductToOrder(Product product);
        IList<Order> GetOrders();
        void CompleteOrder(Order order);
    }
}
