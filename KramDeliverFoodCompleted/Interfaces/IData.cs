using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        IList<Order> Orders { get; set; }
        Order Order { get; set; }
        IList<Product> OrderProducts { get; set; }
        IList<ExchangeRate> Currencies { get; set; }

        void InitProducts();
    }
}