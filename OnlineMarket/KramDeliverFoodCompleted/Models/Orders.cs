using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Orders
    {
        public List<Products> OrderProducts { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal Summary { get;set; }
        public string Currency { get; set; }

        public Orders()
        {
            OrderProducts = new List<Products>();
        }
    }
}