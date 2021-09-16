using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KramDeliveryFoodAPI.Filters
{
    public class HandleExceptionFilter : IExceptionFilter
    {
        private ILogger<HandleExceptionFilter> _logger;
        public HandleExceptionFilter(ILogger<HandleExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            string actionName = context.ActionDescriptor.DisplayName;
            string exceptionStack = context.Exception.StackTrace;
            string exceptionMessage = context.Exception.Message;
            context.Result = new ContentResult
            {
                Content = $"In action: {actionName} were found the exception: \n {exceptionMessage} \n {exceptionStack}"
            };
            context.ExceptionHandled = true;

            _logger.LogError(context.Result.ToString());
        }
    }
}
