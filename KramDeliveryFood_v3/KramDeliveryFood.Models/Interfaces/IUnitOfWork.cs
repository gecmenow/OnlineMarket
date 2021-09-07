namespace KramDelivery.Structure.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        void Dispose();
    }
}
