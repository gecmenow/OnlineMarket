using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class Product
    {
        [ExplicitKey]
        public Guid ProductId { get; set; }
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
