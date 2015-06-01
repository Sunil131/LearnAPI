using System.Web.Http;
using System.Web.Http.Cors;
using TaskAPI.Handlers;
using TaskAPI.Filters;


namespace TaskAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            
            UnityConfig.RegisterComponents(); //Register Unity for IOC


            config.MapHttpAttributeRoutes(); // Web API routes


            config.MessageHandlers.Add(new TokenVerificationHandler()); //Add handler to config for token verification
            

            var cors = new EnableCorsAttribute("*", "*", "GET, POST, PUT, DELETE, OPTIONS"); //enabled all origins,headers adn methods
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new TaskExceptionFilter()); //added exception filter
        }
    }
}
