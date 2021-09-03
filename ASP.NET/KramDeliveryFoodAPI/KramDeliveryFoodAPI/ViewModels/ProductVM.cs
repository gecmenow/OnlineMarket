using System;

namespace KramDeliveryFoodAPI.ViewModels
{
    public class ProductVM
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
    }
}
