using System;

namespace KramDeliveryFood
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Provider Provider { get; set; }
        public string Ingredients { get; set; }
        public string Calories { get; set; }
        public float Weight { get; set; }
        public decimal Price { get; set; }
        public PriceType PriceType { get; set; }
        public string Description { get; set; }
    }
}