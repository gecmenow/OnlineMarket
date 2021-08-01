using System;

namespace KramDelivery.Domain.Models
{
    public class Buyer
    {
        public Guid BuyerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
