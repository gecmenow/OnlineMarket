using KramDeliveryFood_v3.Interfaces;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class StoreContext : IData
    {
        public IList<Products> BaseProducts { get; set; }
        public IList<Orders> Orders { get; set; }
        public Orders Order { get; set; }
        public IList<Products> OrderProducts { get; set; }

        public StoreContext()
        {
            BaseProducts = new List<Products>();
        }

        public void InitProducts()
        {

        }
    }
}
