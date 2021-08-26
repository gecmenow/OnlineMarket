using KramDelivery.Domain.Enums;
using System;
using System.Collections.Generic;

namespace KramDelivery.Domain.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public List<Product> Products { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Guid BuyerId { get; set; }
        public Buyer Buyer { get; set; }
    }
}