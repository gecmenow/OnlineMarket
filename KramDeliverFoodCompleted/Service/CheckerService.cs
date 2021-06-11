using KramDeliverFoodCompleted.Interfaces;
using System.Text.RegularExpressions;

namespace KramDeliverFoodCompleted.Check
{
    public class CheckerService : ICheckerService
    {
        public bool IsPhoneValid(string number)
        {
            var pattern = @"^(\+380|0)(\(\d{2}\)|\d{2})\s?\d{3}\s?\d{2}\s?\d{2}$";
            var expression = new Regex(pattern);
            var isMatch = expression.IsMatch(number);

            return isMatch;
        }

        public bool IsAddressValid(string address)
        {
            var pattern = @"(^([а-я]{5}|[а-я]{2})\s?(.|\s{1})\s?([А-Я][а-я]{9}|[А-Я][а-я]{4})(,|.)\s?([а-я]|[а-я]{3})(.|\s{1})\s?\d{2})|(,\s?([а-я]{2}|[а-я]{8})(.|\s{1})\s?\d{2})$";
            var expression = new Regex(pattern);
            var isMatch = expression.IsMatch(address);

            return isMatch;
        }
    }
}
