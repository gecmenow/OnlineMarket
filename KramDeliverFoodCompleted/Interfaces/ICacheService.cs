using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ICacheService
    {
        public void GetFromCache();
        public void PutInCache();
        public void UpdateCache();

    }
}
