using KramDeliveryFood_v3.Enums;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class Order
    {
        public List<Product> OrderProducts = new();
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}