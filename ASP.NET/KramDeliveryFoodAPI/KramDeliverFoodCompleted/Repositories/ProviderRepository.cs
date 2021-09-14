using KramDelivery.Structure.Models;
using KramDeliveryFood.Data.Data;
using KramDeliveryFood.Structure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly DataContext _context;

        public ProviderRepository(DataContext context)
        {
            _context = context;
        }

        public void AddProduct(Provider provider)
        {
            _context.Providers.Add(provider);
        }

        public Provider GetProviderById(Guid id)
        {
            return _context.Providers.FirstOrDefault(p => p.ProviderId == id);
        }
    }
}
