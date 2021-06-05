using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    interface IOrderService
    {
        string PhoneNumber { get; set; }
        string Address { get; set; }
        IList<Product> OrderProducts { get; set; }

        public void AddProductToOrder(Product product);
        public IList<Order> GetOrders();
    }
}
