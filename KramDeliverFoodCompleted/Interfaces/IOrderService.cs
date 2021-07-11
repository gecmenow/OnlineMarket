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
        IList<Product> GetOrderedProducts();
    }
}
