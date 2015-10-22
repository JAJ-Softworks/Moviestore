using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieShopAssignment
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Had a problem where the filter function would first take you to Movie/Index, and the next time take you to Movie/Movie/Index, and if it could, on and on until Movie/Movie/Movie/Movie/Movie/etc./Index - this one just turns Movie/Movie/Index into Movie/Index
            //Didn't work. No time to fix it.
            routes.MapRoute("SpecificRoute", "Movie/Movie/{action}/{id}", new { controller = "MovieController", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
