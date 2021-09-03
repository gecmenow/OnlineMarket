using System;
using KramDeliverFoodCompleted.Repositories;
using KramDeliverFoodCompleted.Services;
using KramDelivery.Structure.Interfaces;
using KramDeliveryFood.Data.Data;
using KramDeliveryFood.Structure.Interfaces.Repositories;

namespace KramDeliverFoodCompleted.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext db = new();
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IProviderRepository _providerRepository;

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(db);
                return _productRepository;
            }
        }

        public ICategoryRepository Category
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new CategoryRepository(db);
                return _categoryRepository;
            }
        }

        public IProviderRepository Provider
        {
            get
            {
                if (_providerRepository == null)
                    _providerRepository = new ProviderRepository(db);
                return _providerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
