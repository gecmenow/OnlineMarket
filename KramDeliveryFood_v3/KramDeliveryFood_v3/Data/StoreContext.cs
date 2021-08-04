using KramDeliveryFood_v3.Interfaces;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class StoreContext : IData
    {
        public IList<Product> BaseProducts { get; set; }
        public IList<Order> Orders { get; set; }
        public Order Order { get; set; }
        public IList<Product> OrderProducts { get; set; }

        public StoreContext()
        {
            BaseProducts = new List<Product>();
        }

        public void InitProducts()
        {

        }
    }
}
