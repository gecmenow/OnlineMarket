using KramDelivery.Structure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KramDelivery.Structure.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        IList<Order> Orders { get; set; }
        IList<Provider> Providers { get; set; }
        IList<Category> Categories { get; set; }
        Order Order { get; set; }
        IList<Product> OrderProducts { get; set; }
        IList<ExchangeRate> Currencies { get; set; }

        void InitProducts();
    }
}