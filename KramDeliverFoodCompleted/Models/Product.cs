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
<<<<<<< HEAD
            } 
=======
            }
>>>>>>> fa27adc441d9a79a07873e4c2d774239356dbeb7
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
<<<<<<< HEAD
        public decimal Price 
=======
      
        public decimal Price
>>>>>>> fa27adc441d9a79a07873e4c2d774239356dbeb7
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
<<<<<<< HEAD
        public string Specifications 
=======
      
        public string Specifications
>>>>>>> fa27adc441d9a79a07873e4c2d774239356dbeb7
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
<<<<<<< HEAD
=======
      
>>>>>>> fa27adc441d9a79a07873e4c2d774239356dbeb7
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
