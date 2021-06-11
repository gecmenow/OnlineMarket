using System;

namespace KramDeliverFoodCompleted.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        private string _name { get; set; }
        private decimal _price { get; set; }
        private string _specifications { get; set; }
        private string _description { get; set; }

        public string Name 
        { 
            get
            {
                return _name;
            } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public decimal Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }

        public string Specifications 

        {
            get
            {
                return _specifications;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _specifications = value;
                }
            }
        }

        public string Description 
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                }
            }
        }
    }
}
