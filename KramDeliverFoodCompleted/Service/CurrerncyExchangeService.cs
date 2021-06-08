using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using Newtonsoft.Json;

namespace KramDeliverFoodCompleted.Service
{
    public class CurrerncyExchangeService : ICurrerncyExchangeService
    {
        public async Task<string> GetCurrencies()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.privatbank.ua/p24api/exchange_rates?json&date=01.12.2014");
            var response = await client.SendAsync(request).ConfigureAwait(false);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
