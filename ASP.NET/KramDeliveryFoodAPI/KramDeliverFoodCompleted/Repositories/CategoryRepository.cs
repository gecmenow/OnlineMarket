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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public IList<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(Guid id)
        {
            return _context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
        }
    }
}
