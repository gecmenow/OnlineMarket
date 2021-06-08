using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        IList<Order> Orders { get; set; }
        Order Order { get; set; }
        IList<Product> OrderProducts { get; set; }

        void InitProducts();
    }
}
