using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Order
    {
        public List<Product> OrderProducts { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Order()
        {
            OrderProducts = new List<Product>();
        }
    }
}