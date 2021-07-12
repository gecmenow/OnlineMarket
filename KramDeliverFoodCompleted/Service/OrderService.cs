using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using static KramDeliverFoodCompleted.Interfaces.ICurrerncies;
using System.Text.RegularExpressions;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        private readonly IData _data;
        private readonly ILoggerService _loggerService;
        private readonly ICurrerncies _currerncyExchangeService;

        public OrderService(IData data, ILoggerService loggerService, ICurrerncies currerncyExchangeService)
        {
            _data = data;
            _data.Orders = new List<Order>();
            _data.Order = new Order();
            _loggerService = loggerService;
            _currerncyExchangeService = currerncyExchangeService;
        }

        public void AddProductToOrder(Product product)
        {
            _data.Order.OrderProducts.Add(product);
            _loggerService.AddLog("Product was added to order " + product.Id);
        }

        public Order GetOrder()
        {
            return _data.Order;
        }

        public IList<Order> GetOrders()
        {
            return _data.Orders;
        }

        public bool SetPhoneNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            _data.Order.PhoneNumber = number;

            return true;
        }

        public bool SetAddressNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }

            _data.Order.Address = number;
            return true;
        }

        public void CompleteOrder(Order order)
        {
            _data.Orders.Add(order);
        }

        public void ClearOrders()
        {
            _data.Orders.Clear();
        }

        public void GetSummary(int currency)
        {
            var currencies = _currerncyExchangeService.GetCurrencies().Result;

            _data.Currencies = JsonConvert.DeserializeObject<Currency>(currencies).ExchangeRate.Where(x => x.Currency != null).ToList();

            foreach (var product in _data.Order.OrderProducts)
            {
                _data.Order.Summary += product.Price;
            }

            _data.Order.Summary = ConvertSummary(currency);
        }

        public bool IsPhoneValid(string input)
        {
            if (checkPhone(input))
            {
                _data.Order.PhoneNumber = input;

                return true;
            }

            return false;
        }

        public bool IsAddressValid(string input)
        {
            if (checkAddress(input))
            {
                _data.Order.Address = input;

                return true;
            }

            return false;
        }

        private bool checkPhone(string number)
        {
            var pattern = @"^(\+380|0)(\(\d{2}\)|\d{2})\s?\d{3}\s?\d{2}\s?\d{2}$";
            var expression = new Regex(pattern);
            var isMatch = expression.IsMatch(number);

            return isMatch;
        }

        private bool checkAddress(string address)
        {
            var pattern = @"(^([а-я]{5}|[а-я]{2})\s?(.|\s{1})\s?([А-Я][а-я]{9}|[А-Я][а-я]{4})(,|.)\s?([а-я]|[а-я]{3})(.|\s{1})\s?\d{2})|(,\s?([а-я]{2}|[а-я]{8})(.|\s{1})\s?\d{2})$";
            var expression = new Regex(pattern);
            var isMatch = expression.IsMatch(address);

            return isMatch;
        }

        private decimal ConvertSummary(int currency)
        {
            var convertedSummary = 0M;

            switch (currency)
            {
                case (int)Currencies.Eur:
                    var value = _data.Currencies.Where(x => x.Currency == Currencies.Eur.ToString().ToUpper()).Select(x => x.PurchaseRate).FirstOrDefault();
                    convertedSummary = _data.Order.Summary / value;
                    _data.Order.Currency = Currencies.Eur.ToString();
                    break;
                case (int)Currencies.Usd:
                    value = _data.Currencies.Where(x => x.Currency == Currencies.Usd.ToString().ToUpper()).Select(x => x.PurchaseRate).FirstOrDefault();
                    convertedSummary = _data.Order.Summary / value;
                    _data.Order.Currency = Currencies.Usd.ToString();
                    break;
                default:
                    convertedSummary = _data.Order.Summary;
                    break;
            }

            return convertedSummary;
        }
    }
}
