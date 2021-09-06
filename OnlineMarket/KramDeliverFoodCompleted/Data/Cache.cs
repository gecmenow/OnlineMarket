using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Data
{
    public class Cache : ICache
    {
        public List<Product> CacheData { get; set; }

        public Cache()
        {
            CacheData = new List<Product>();
        }
    }
}
