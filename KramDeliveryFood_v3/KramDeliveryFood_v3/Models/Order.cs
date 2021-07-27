using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class Order
    {
        public List<Product> OrderProducts { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order()
        {
            OrderProducts = new List<Product>();
        }
    }
}