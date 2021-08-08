﻿using KramDeliveryFood_v3.Enums;
using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal FullPrice { get; set; }
        public Deliver Deliver { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<Product> OrderProducts { get; set; }
    }
}