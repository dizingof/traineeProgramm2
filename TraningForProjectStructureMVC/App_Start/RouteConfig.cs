using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TraningForProjectStructureMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "DefaultQwerty",
               url: "1{controller}/qwerty{action}/{id}",
               defaults: new { controller = "Test", action = "CustomAction", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "DefaultNew",
                url: "{controller}/123{action}/{id}",
                defaults: new { controller = "Home", action = "General", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            

        }
    }
}
