using System;
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
        private readonly string apiLink = "https://api.privatbank.ua/p24api/exchange_rates?json&date=";
        private string date = DateTime.Today.AddDays(-1).ToString("dd.MM.yyyy");

        public async Task<string> GetCurrencies()
        {         
            using (var client = new HttpClient())
            {
                var link = apiLink + date;
                HttpResponseMessage response = await client.GetAsync(link);

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
