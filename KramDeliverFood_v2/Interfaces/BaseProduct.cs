using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public abstract class BaseProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public IList<BaseProduct> Products { get; set; }

        public virtual void AddProduct(BaseProduct product)
        { }
    }
}
