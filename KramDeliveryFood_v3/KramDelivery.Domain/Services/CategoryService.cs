using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using System.Collections.Generic;

namespace KramDelivery.Domain.Service
{
    public class CategoryService : ICategoryService
    {
        private IData _data;
        public CategoryService(IData data)
        {
            _data = data;
        }

        public IList<Category> GetCategories()
        {
            return _data.Categories;
        }
    }
}
