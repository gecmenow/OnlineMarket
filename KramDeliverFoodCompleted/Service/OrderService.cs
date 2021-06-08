﻿using KramDeliverFoodCompleted.Interfaces;
using KramDeliverFoodCompleted.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using static KramDeliverFoodCompleted.Interfaces.ICurrerncyExchangeService;

namespace KramDeliverFoodCompleted.Service
{
    public class OrderService : IOrderService
    {
        private readonly IData _data;
        private readonly ICheckerService _checker;
        private readonly ILoggerService _loggerService;
        private readonly ICurrerncyExchangeService _currerncyExchangeService;

        public OrderService(IData data, ICheckerService checker, ILoggerService loggerService, ICurrerncyExchangeService currerncyExchangeService)
        {
            _data = data;
            _checker = checker;
            _loggerService = loggerService;
            _currerncyExchangeService = currerncyExchangeService;
            _data.Orders = new List<Order>();
            _data.Order = new Order();
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

        public IList<Product> GetOrderedProducts()
        {
            return _data.Order.OrderProducts;
        }

        public void GetSummary(int currency)
        {
            foreach (var product in _data.Order.OrderProducts)
            {
                _data.Order.Summary += product.Price;
            }

            _data.Order.Summary = ConvertSummary(currency, _data.Order.Summary);
        }

        decimal ConvertSummary(int currency, decimal summary)
        {
            var currencies = _currerncyExchangeService.GetCurrencies();

            Root currenciesModel = JsonConvert.DeserializeObject<Root>(currencies.ToString());

            var convertedSummary = 0M;

            switch (currency)
            {
                case (int)Currencies.eur:
                    var value = currenciesModel.ExchangeRate.Where(x => int.Parse(x.Currency) == currency).Select(x => x.PurchaseRate).FirstOrDefault();
                    convertedSummary = summary * value;
                    _data.Order.Currency = Currencies.eur.ToString();
                    break;
                case (int)Currencies.usd:
                    value = currenciesModel.ExchangeRate.Where(x => int.Parse(x.Currency) == currency).Select(x => x.PurchaseRate).FirstOrDefault();
                    convertedSummary = summary * value;
                    _data.Order.Currency = Currencies.usd.ToString();
                    break;
                default:
                    convertedSummary = summary;
                    break;
            }

            return convertedSummary;
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
    }
}
