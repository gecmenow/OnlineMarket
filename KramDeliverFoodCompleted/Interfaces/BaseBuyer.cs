using KramDeliverFoodCompleted;
using System;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Interfaces
{
    public abstract class BaseBuyer
    {
        public Guid Id { get; set; }
        public IEnumerable<string> Products { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public void Order()
        { }

        protected void Checkout(IEnumerable<BaseProduct> products, string information)
        { }
    }
}
