using KramDeliverFoodCompleted.Interfaces;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class StoreContext : IData
    {
        public IList<Product> BaseProducts { get; set; }
        public Order Order { get; set; }

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
