using Fullstack.Demo.WebApi.App_Start;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Fullstack.Demo.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
              
            // Web API configuration and services
            config.Filters.Add(new CustomExceptionFilter());  


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

        }
    }
}
