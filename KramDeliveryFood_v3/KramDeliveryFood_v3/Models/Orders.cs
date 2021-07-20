using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class Orders
    {
        public List<Products> OrderProducts { get; set; }
        public Buyers Buyer { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal FullPrice { get; set; }
        public Delivers Delivers { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Orders()
        {
            OrderProducts = new List<Products>();
        }
    }
}