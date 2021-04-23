using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFood_v2
{
    interface IBuyer
    {
        public IEnumerable<string> Order(string prodcuts);

        public Checkout Checkout(IEnumerable<string> products, string information);
    }
}
