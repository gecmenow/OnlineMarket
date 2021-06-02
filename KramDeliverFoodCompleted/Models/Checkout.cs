using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Checkout
    {
        public IEnumerable<Data.Product> Order { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}