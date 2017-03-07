using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DptsData
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
<<<<<<< HEAD
               // defaults: new { controller = "UploadFile", action = "Index", id = UrlParameter.Optional }
=======
>>>>>>> 8292167de7131b010ff3fc497ee47e64e548224d
            );
        }
    }
}
<<<<<<< HEAD
//"Home"
=======
>>>>>>> 8292167de7131b010ff3fc497ee47e64e548224d
