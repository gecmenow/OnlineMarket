using System;
using KramDelivery.Structure.Interfaces;
using KramDeliveryFood;
using KramDeliveryFood.Data.Data;

namespace KramDelivery.Domain.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext db = new();
        private ProductService productService;

        public ProductService Products
        {
            get
            {
                if (productService == null)
                    productService = new ProductService(db);
                return productService;
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
