using System;

namespace KramDeliveryFood_v3.Models
{
    public class Provider
    {
        public Guid ProdviderId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
