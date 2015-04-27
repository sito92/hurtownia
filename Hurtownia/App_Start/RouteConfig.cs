﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Hurtownia
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "MyRoute",
                url: "{controller}",
                defaults: new { action = "List", id = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}