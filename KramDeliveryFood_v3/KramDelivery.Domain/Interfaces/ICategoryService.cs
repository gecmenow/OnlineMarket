using KramDelivery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDelivery.Domain.Interfaces
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
