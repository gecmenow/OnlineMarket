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

<<<<<<< HEAD
        public string Name
        {
            get
            {
                return _name;
            }
=======
        public string Name 
        { 
            get
            {
                return _name;
            } 
>>>>>>> main
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
>>>>>>> main
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
>>>>>>> main
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
        public string Description
=======
        public string Description 
>>>>>>> main
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
