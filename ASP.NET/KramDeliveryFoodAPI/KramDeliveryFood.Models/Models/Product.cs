using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KramDelivery.Structure.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        public Category Category { get; set; }
        public Provider Provider { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid ProviderId { get; set; }
        public decimal Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
    }
}
