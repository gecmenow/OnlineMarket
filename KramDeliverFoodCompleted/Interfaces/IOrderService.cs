using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        Order GetOrder();
        void CompleteOrder(Order order);
        bool SetPhoneNumber(string number);
        bool SetAddressNumber(string number);
        void AddProductToOrder(Product product);
        bool IsPhoneValid(string number);
        bool IsAddressValid(string number);
        IList<Order> GetOrders();
        void GetSummary(int currency);
        void ClearOrders();
    }
}
