using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using Newtonsoft.Json;

namespace KramDeliverFoodCompleted.Service
{
    public class CurrerncyExchangeService : ICurrerncyExchangeService
    {
        //private string url = "https://api.privatbank.ua/p24api/exchange_rates?json&date=09.07.2021";

        public async Task<IList<ExchangeRate>> GetCurrencies()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.privatbank.ua/p24api/exchange_rates?json&date=09.07.2021");
                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var articles = JsonConvert.DeserializeObject<Currency>(responseBody).ExchangeRate.Where(x => x.Currency != null).ToList(); ;
                    //var tmp = articles.ExchangeRate.ToList();

                    //foreach(var article in tmp)
                    //{
                    //    if (article.Currency == null)
                    //    {
                    //        tmp.Remove(article);
                    //    }
                    //}

                    //articles.ExchangeRate = tmp.ToList();
                    //tmp.Clear();

                    return articles;
                }

                

                //return response.Content.ReadAsStringAsync();
            }
        }
    }
}
