using System;
using System.ComponentModel.DataAnnotations;

namespace KramDeliveryFoodAPI.ViewModels
{
    public class ProductVM
    {
        public Guid ProductId { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public Guid ProviderId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string CategoryName { get; set; }
        [Required]
        [Range(50, 250)]
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
    }
}
