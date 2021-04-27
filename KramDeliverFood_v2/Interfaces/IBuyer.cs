using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFood_v2.Interfaces
{
    interface IBuyer
    {
        public void Order();

        public Checkout Checkout(IEnumerable<string> products, string information);
    }
}
