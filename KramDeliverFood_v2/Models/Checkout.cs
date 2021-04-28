using KramDeliverFoodCompleted.Interfaces;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Checkout
    {
        public IEnumerable<Product> Order { get; set; }
        public string Information { get; set; }
    }
}