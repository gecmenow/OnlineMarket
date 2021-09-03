using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProviderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddProvider(Provider provider)
        {
            _unitOfWork.Provider.AddProduct(provider);
        }

        public Provider GetProviderById(Guid id)
        {
            return _unitOfWork.Provider.GetProviderById(id);
        }
    }
}
