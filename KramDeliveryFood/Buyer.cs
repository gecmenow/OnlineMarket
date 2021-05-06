using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliveryFood
{
    public class Buyer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public PaymentMethod PayMethod { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public string PromoCode { get; set; }
    }
}
