using KramDelivery.Structure.Interfaces;
using KramDelivery.Structure.Models;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Category> GetCategories()
        {
            return _unitOfWork.Category.GetCategories();
        }

        public Category GetCategoryById(Guid id)
        {
            return _unitOfWork.Category.GetCategoryById(id);
        }
    }
}
