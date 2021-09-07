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
        private IProductRepository _productService;

        public IProductRepository Products
        {
            get
            {
                if (_productService == null)
                    _productService = new ProductRepository(db);
                return _productService;
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
