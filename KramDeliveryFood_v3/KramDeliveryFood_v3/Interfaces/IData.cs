using KramDeliveryFood_v3.Models;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Interfaces
{
    public interface IData
    {
        IList<Products> BaseProducts { get; set; }
        IList<Orders> Orders { get; set; }
        Orders Order { get; set; }
        IList<Products> OrderProducts { get; set; }

        void InitProducts();
    }
}
