using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        Order Order { get; set; }

        void InitProducts();
    }
}
