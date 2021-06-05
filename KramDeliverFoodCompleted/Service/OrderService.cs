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
        private readonly StoreContext _data;

        public OrderService(StoreContext data)
        {
            _data = data;
            _data.Order = new Order();
        }

        public void AddProductToOrder(Product product)
        {
            _data.Order.OrderProducts.Add(product);
        }

        public IList<Product> GetOrderedProducts()
        {
            return _data.Order.OrderProducts;
        }
    }
}
