using KramDeliveryFood.Structure.Interfaces.Repositories;

namespace KramDelivery.Structure.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IProviderRepository Provider { get; }
        void Save();
        void Dispose();
    }
}
