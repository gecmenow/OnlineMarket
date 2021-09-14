using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliveryFood.Structure.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        IList<Category> GetCategories();
        Category GetCategoryById(Guid id);
    }
}
