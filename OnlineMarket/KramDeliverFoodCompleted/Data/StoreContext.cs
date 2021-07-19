using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class StoreContext : IData
    {
        public IList<Products> BaseProducts { get; set; }
        public IList<Orders> Orders { get; set; }
        public Orders Order { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IList<Products> OrderProducts { get; set; }
        private readonly ISerializerService _serializerService;

        public StoreContext(ISerializerService serializerService)
        {
            BaseProducts = new List<Products>();
            _serializerService = serializerService;
        }

        public void InitProducts()
        {
            BaseProducts = _serializerService.DoDeserialization<Products>();
        }
    }
}
