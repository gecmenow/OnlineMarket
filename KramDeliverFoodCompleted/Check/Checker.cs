using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;
using KramDeliverFoodCompleted.Serialize;
using System;

namespace KramDeliverFoodCompleted.Check
{
    public class Checker
    {
        public static bool EmptyUserInput(string input)
        {
            var flag = false;

            if (!string.IsNullOrWhiteSpace(input))
                flag = true;

            return flag;
        }

        public static bool NonLetterUserInput(object input)
        {
            var flag = input is string;

            return flag;
        }

        public static bool UserLengthInput(string input)
        {
            var flag = false;

            if (input.Length == 1)
                flag = true;

            return flag;
        }

        ///<summary>
        ///<para> This method is checinkg user input for buying more products </para>
        ///<para> and expecting y or n incoming. </para>
        ///</summary>
        public static bool BuyMoreProductsCorrect(string input)
        {
            var flag = false;

            var inputSymbol = Convert.ToChar(input);

            if (char.IsLetter(inputSymbol))
                if(inputSymbol == 'y' ||inputSymbol == 'n')
                    flag = true;

            return flag;
        }

        public static bool BuyMoreProducts(string input)
        {
            var flag = false;

            if (input == "y")
                flag = true;

            return flag;
        }

        public static bool RealProductId(int id)
        {
            var flag = false;

            var product = new Product();

            var productsLength = product.GetProducts().Count;

            if (id >= 0 && id < productsLength)
                flag = true;

            return flag;
        }
    }
}
