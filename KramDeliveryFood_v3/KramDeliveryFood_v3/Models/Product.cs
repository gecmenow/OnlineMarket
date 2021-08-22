using System;

namespace KramDeliveryFood_v3.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
    }
}
