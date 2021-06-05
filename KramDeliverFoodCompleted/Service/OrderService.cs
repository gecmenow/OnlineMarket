using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IList<Product> OrderProducts { get; set; }
        private readonly IData _data;
        private readonly Order _order;

        public OrderService(IData data)
        {
            _data = data;
            _data.Orders = new List<Order>();
            _order = new Order();
        }

        public void AddProductToOrder(Product product)
        {
            _order.OrderProducts.Add(product);
        }

        public Order GetOrder()
        {
            return _order;
        }

        public IList<Order> GetOrders()
        {
            return _data.Orders;
        }

        public void CompleteOrder(Order order)
        {
            _data.Orders.Add(order);
        }
    }
}
