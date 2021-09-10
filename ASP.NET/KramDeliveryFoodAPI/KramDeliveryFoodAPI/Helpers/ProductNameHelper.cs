using KramDelivery.Structure.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace KramDeliveryFoodAPI.Helpers
{
    public static class ProductNameHelper
    {
        public static HtmlString ShowProductName(this IHtmlHelper html, List<Product> items)
        {
            var result = "<ol>";
            foreach (var item in items)
            {
                result = $"{result}<li>{item.Name}</li>";
            }
            result = $"{result}</ol>";
            return new HtmlString(result);
        }
    }
}
