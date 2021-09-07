using KramDeliveryFood.Structure.Interfaces.Repositories;

namespace KramDelivery.Structure.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        void Save();
        void Dispose();
    }
}
