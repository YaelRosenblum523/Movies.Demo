using Fullstack.Demo.Common.UoW;
using Fullstack.Demo.UoW;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Fullstack.Demo.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IMovieManagementUoW, MovieManagementUoW>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}