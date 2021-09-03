using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Service
{
    public class CacheService : ICacheService
    {
        private readonly ICache _cache;
        private static readonly object _locker = new();

        public CacheService(ICache cache)
        {
            _cache = cache;
        }

        public void AddToCache(Product data)
        {
            lock (_locker)
            {
                if (_cache.CacheData.Count == 5)
                {
                    _cache.CacheData.RemoveAt(0);
                }

                _cache.CacheData.Add(data);
            }
        }

        public IList<Product> GetFromCache()
        {
            lock (_locker)
            {
                return _cache.CacheData.Any() ? _cache.CacheData : default;
            }
        }

        public void DeleteFromCache(Product data)
        {
            lock (_locker)
            {
                var result = _cache.CacheData.Where(d => d.Id == data.Id).FirstOrDefault();

                if (result != null)
                {
                    _cache.CacheData.Remove(data);
                }
            }
        }
    }
}
