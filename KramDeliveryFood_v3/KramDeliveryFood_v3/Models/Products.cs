using System;

namespace KramDeliveryFood_v3.Models
{
    public class Products
    {
        public Guid Id { get; set; }
        private string _name { get; set; }
        private Guid _categoryId { get; set; }
        private Guid _providerId { get; set; }
        private decimal _price { get; set; }
        private string _specifications { get; set; }
        private string _description { get; set; }
        private string _productType { get; set; }
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

        public Guid CategoryId
        {
            get
            {
                return _categoryId;
            }
            set
            {
                if (value != Guid.Empty)
                {
                    _categoryId = value;
                }
            }
        }

        public Guid ProviderId
        {
            get
            {
                return _providerId;
            }
            set
            {
                if (value != Guid.Empty)
                {
                    _providerId = value;
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

        public string ProductType
        {
            get
            {
                return _productType;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _productType = value;
                }
            }
        }
    }
}
