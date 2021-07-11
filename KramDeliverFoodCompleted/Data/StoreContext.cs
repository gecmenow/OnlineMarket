using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Data
{
    public class StoreContext : IData
    {
        public IList<Product> BaseProducts { get; set; }
        public Order Order { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Product> OrderProducts { get; set; }
        public IList<ExchangeRate> Currencies { get; set; }

        private readonly ISerializerService _serializerService;

        public StoreContext(ISerializerService serializerService)
        {
            BaseProducts = new List<Product>();
            _serializerService = serializerService;
        }

        public void InitProducts()
        {
            BaseProducts = _serializerService.DoDeserialization<Product>();
        }
    }
}
