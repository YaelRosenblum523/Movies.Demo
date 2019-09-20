using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Fullstack.Demo.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IConfigurationSource c = ConfigurationSourceFactory.Create();
            ExceptionPolicyFactory factory = new ExceptionPolicyFactory(c);

            Logger.SetLogWriter(new LogWriterFactory().Create());
            ExceptionManager exManager = factory.CreateManager();
            ExceptionPolicy.SetExceptionManager(factory.CreateManager());

            UnityConfig.RegisterComponents();                        
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
