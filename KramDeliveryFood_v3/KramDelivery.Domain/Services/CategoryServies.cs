using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using System.Collections.Generic;

namespace KramDelivery.Domain.Service
{
    public class CategoryServies : ICategoryService
    {
        private IData _data;
        public CategoryServies(IData data)
        {
            _data = data;
        }

        public IList<Category> GetCategories()
        {
            return _data.Categories;
        }
    }
}
