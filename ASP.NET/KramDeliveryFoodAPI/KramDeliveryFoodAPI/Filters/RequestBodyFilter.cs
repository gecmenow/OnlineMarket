using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KramDeliveryFoodAPI.Filters
{
    public class RequestBodyFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var result = context.Result as ObjectResult;

            var value = ((IEnumerable)result.Value).Cast<object>().ToList();

            foreach(var data in value)
            {
                Console.WriteLine(data);
            } 
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Executing a request");
        }
    }
}
