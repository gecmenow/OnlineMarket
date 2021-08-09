using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Products product);
        IList<Products> GetProducts();
        bool IsRealProductId(int input);
        Products GetProductById(int input);
    }
}
