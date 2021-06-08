using Newtonsoft.Json;
using System.Collections.Generic;

namespace KramDeliverFoodCompleted.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ExchangeRate
    {
        [JsonProperty("baseCurrency")]
        public string BaseCurrency { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("saleRateNB")]
        public double SaleRateNB { get; set; }

        [JsonProperty("purchaseRateNB")]
        public double PurchaseRateNB { get; set; }

        [JsonProperty("saleRate")]
        public double? SaleRate { get; set; }

        [JsonProperty("purchaseRate")]
        public decimal PurchaseRate { get; set; }
    }

    public class Root
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("baseCurrency")]
        public int BaseCurrency { get; set; }

        [JsonProperty("baseCurrencyLit")]
        public string BaseCurrencyLit { get; set; }

        [JsonProperty("exchangeRate")]
        public List<ExchangeRate> ExchangeRate { get; set; }
    }
}
