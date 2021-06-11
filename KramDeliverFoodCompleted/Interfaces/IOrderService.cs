using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        void AddProductToOrder(Product product);
        IList<Order> GetOrders();
        Order GetOrder();
        void CompleteOrder(Order order);
    }
}
