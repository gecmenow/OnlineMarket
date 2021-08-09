using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class Provider
    {
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
