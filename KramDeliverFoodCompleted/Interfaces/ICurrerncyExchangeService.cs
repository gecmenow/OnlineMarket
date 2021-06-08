using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ICurrerncyExchangeService
    {
        enum Currencies
        { 
            usd,
            eur,
            uah
        }

        Task<string> GetCurrencies();
    }
}
