using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;

namespace Fullstack.Demo.WebApi.App_Start
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            ExceptionPolicy.HandleException(actionExecutedContext.Exception, "Policy");
            string exceptionMessage = string.Empty;
            if (actionExecutedContext.Exception.InnerException == null)
            {
                exceptionMessage = actionExecutedContext.Exception.Message;
            }
            else
            {
                exceptionMessage = actionExecutedContext.Exception.InnerException.Message;
            }
            //We can log this exception message to the file or database.  
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("An unhandled exception was thrown by service."),
                ReasonPhrase = "Internal Server Error.Please Contact your Administrator."
            };
            actionExecutedContext.Response = response;
        }
    }
}