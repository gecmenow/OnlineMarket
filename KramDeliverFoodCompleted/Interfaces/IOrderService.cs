using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        public void AddProductToOrder(Product product);
        public IList<Order> GetOrders();
        Order GetOrder();
        public bool IsPhoneValid(string number);
        public bool IsAddressValid(string number);
        void CompleteOrder(Order order);
    }
}
