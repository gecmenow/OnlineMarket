using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
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
