using System;

namespace KramDelivery.Domain.Models
{
    public class Provider
    {
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
