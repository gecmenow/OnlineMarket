using KramDeliverFood_v2.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFood_v2.Check
{
    class Checker
    {
        public static bool EmptyUserInput(string input)
        {
            var flag = false;

            if (!String.IsNullOrWhiteSpace(input))
                flag = true;

            return flag;
        }

        public static bool NonStringUserInput(string input)
        {
            var flag = false;

            try
            {
                var converted = Convert.ToInt32(input);
            }
            catch (Exception ex)
            {
                Logger.ExceptionMessage(ex);
            }

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
        public static bool BuyMoreProducts(string input)
        {
            var flag = false;

            var inputSymbol = Convert.ToChar(input);

            if (Char.IsLetter(inputSymbol))
                flag = true;

            return flag;
        }

        public static bool RealProductId(int id)
        {
            var flag = false;

            

            return flag;
        }
    }
}
