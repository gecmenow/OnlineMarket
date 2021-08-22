using KramDeliveryFood_v3.Models;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        IList<Order> Orders { get; set; }
        IList<Provider> Providers { get; set; }
        IList<Category> Categories { get; set; }
        Order Order { get; set; }
        IList<Product> OrderProducts { get; set; }

        void InitProducts();
    }
}
