using KramDeliverFoodCompleted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ICacheService
    {
        void AddToCache(Product data);
        IList<Product> GetFromCache();
        void DeleteFromCache(Product data) ;
    }
}
