using System.Web.Mvc;
using System.Web.Routing;

namespace TestProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Person", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}