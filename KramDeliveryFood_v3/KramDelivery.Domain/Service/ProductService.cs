using KramDelivery.Domain.Interfaces;
using KramDelivery.Domain.Models;
using KramDeliveryFood.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace KramDelivery.Domain.Service
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService()
        {
            _context = new DataContext();
        }
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public IList<Product> GetProducts()
        {
            return _context.Products.Include(p => p.Provider).Include(c => c.Categorie).AsNoTracking().ToList();
        }

        public IList<Product> GetAllWithTracking()
        {
            return _context.Products.Include(p => p.Provider).Include(c => c.Categorie).ToList();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }
    }
}