using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
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
        private readonly IWebHostEnvironment _env;

        public HandleExceptionFilter(ILogger<HandleExceptionFilter> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            if (_env.IsProduction())
            {
                Console.WriteLine("Occured an error. Check this message: " + context.Exception.Message);
            }
            else if (_env.EnvironmentName == "QA")
            {
                Console.WriteLine("Occured an error. Check this message: " + context.Exception.Message + ".\n" +
                    "Also, watch call stack " + context.Exception.StackTrace);
            }

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
