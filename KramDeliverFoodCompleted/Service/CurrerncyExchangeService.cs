using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using Newtonsoft.Json;

namespace KramDeliverFoodCompleted.Service
{
    public class CurrerncyExchangeService : ICurrerncies
    {
        public async Task<string> GetCurrencies()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.privatbank.ua/p24api/exchange_rates?json&date=09.07.2021");

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
