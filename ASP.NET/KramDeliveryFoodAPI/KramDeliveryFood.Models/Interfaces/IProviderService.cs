using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDelivery.Structure.Interfaces
{
    public interface IProviderService
    {
        Provider GetProviderById(Guid id);
        void AddProvider(Provider provider);
    }
}
