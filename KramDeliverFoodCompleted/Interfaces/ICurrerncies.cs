using KramDeliverFoodCompleted.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interfaces
{
    public interface ICurrerncies
    {
        enum Currencies
        { 
            Usd,
            Eur,
            Uah
        }

        Task<string> GetCurrencies();
    }
}
