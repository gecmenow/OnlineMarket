using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;
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

        Task<IList<ExchangeRate>> GetCurrencies();
    }
}
