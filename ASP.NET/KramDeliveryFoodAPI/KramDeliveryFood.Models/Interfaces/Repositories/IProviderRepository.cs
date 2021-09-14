using KramDelivery.Structure.Models;
using System;

namespace KramDeliveryFood.Structure.Interfaces.Repositories
{
    public interface IProviderRepository
    {
        void AddProduct(Provider provider);
        Provider GetProviderById(Guid id);
    }
}
