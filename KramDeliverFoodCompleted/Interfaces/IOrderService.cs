using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IOrderService
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IList<Product> OrderProducts { get; set; }

        public void AddProductToOrder(Product product);
        public IList<Product> GetOrderedProducts();
    }
}
