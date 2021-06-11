using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IData
    {
        IList<Product> BaseProducts { get; set; }
        IList<Order> Orders { get; set; }
<<<<<<< HEAD
        Order Order { get; set; }
=======
        public Order Order { get ; set; }
>>>>>>> main
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IList<Product> OrderProducts { get; set; }

        void InitProducts();
    }
}
