using KramDelivery.Domain.Interfaces;
using KramDelivery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
