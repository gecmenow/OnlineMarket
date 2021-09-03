using KramDelivery.Structure.Models;
using System.Collections.Generic;

namespace KramDelivery.Structure.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        IList<Order> Orders { get; set; }
        Order Order { get; set; }
        IList<Product> OrderProducts { get; set; }
        IList<Category> Categories { get; set; }

        void InitProducts();
    }
}
