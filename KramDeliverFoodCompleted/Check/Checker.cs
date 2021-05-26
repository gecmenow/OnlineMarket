using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
using System;

namespace KramDeliverFoodCompleted.Check
{
    public class Checker
    {
        private readonly Product _product;

        public Checker(Product product)
        {
            _product = product;
        }
        ///<summary>
        ///This method is checinkg user input for buying more products
        ///and expecting y or n incoming.
        ///</summary>
        public static bool IsBuyMoreProducts(string input)
        {
            return (input == "y" || input == "n") ? true : false;
        }

        public bool IsRealProductId(int id)
        {
            var flag = false;

            var productsLength = _product.GetProducts().Count;

            if (id >= 0 && id < productsLength)
                flag = true;

            return flag;
        }
    }
}
