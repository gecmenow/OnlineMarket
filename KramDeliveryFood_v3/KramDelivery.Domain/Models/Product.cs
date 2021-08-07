using System;
using System.Collections.Generic;

namespace KramDelivery.Domain.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public Category Categorie { get; set; }
        public Provider Provider { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid ProviderId { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
        public List<Order> OrderProducts = new();
    }
}
