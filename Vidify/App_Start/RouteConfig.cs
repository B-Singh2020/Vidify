using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidify
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            
            
            /*  Convention based route ex
            routes.MapRoute(                                          //custom route
                "MoviesByReleaseDate",                                //route name
                "movies/released/{year}/{month}",                     //actual url path
                new {controller = "Movies", action = "ByReleaseDate"}, //assigned controller and action
                new {year = @"\d{4}", month = @"\d{2}" }                //constraint
                ); 
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
