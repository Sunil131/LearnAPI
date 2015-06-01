using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using TaskAPI.Controllers;

namespace TaskAPI
{
    public static class UnityConfig
    {

        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity"); //configure from the unity Section in web.config
            section.Configure(container);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}