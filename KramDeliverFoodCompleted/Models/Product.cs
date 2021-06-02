using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
    }
}
