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
        private static readonly object _locker = new object();

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
                    _cache.CacheData.RemoveAt(1);
                }

                _cache.CacheData.Add(data);
            }
        }

        public IList<Product> GetFromCache()
        {
            lock (_locker)
            {
                if (_cache.CacheData.Count != 0)
                {
                    while (_cache.CacheData.Count < 5)
                    {
                        return _cache.CacheData;
                    }

                    return _cache.CacheData;
                }

                return default;
            }
        }

        public void DeleteFromCache(Product data)
        {
            lock (_locker)
            {
                _cache.CacheData.Remove(data);
            }
        }
    }
}
