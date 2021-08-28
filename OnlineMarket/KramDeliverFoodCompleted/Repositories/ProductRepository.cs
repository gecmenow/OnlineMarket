using KramDelivery.Structure.Models;
using KramDeliveryFood.Data.Data;
using KramDeliveryFood.Structure.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public IList<Product> GetAllProducts()
        {
            return _context.Products.Include(c => c.Categorie).Include(p => p.Provider).ToList();
        }

        public IList<Product> GetProductsByCategoryName(string category)
        {
            return _context.Products.Where(p => p.CategoryName == category).Include(c => c.Categorie).Include(p => p.Provider).ToList();
        }

        public Product GetProductById(Guid id)
        {
            return _context.Products.Where(p => p.ProductId == id).FirstOrDefault();
        }

        public void AddProduct(Product product)
        {
            _context.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            _context.Update(product);
        }

        public void RemoveProduct(Product product)
        {
            _context.Remove(product);
        }
    }
}
