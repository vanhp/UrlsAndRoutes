using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // create route by hand
            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{ *catchall} ",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                });
        

        //routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
        //        new
        //        {
        //            controller = "Home",
        //            action = "Index",
        //            id = UrlParameter.Optional
        //        });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = "DefaultId"
            //    });



            ////alias an action
            //routes.MapRoute("ShopSchema2", "Shop/OldAction",
            //        new { controller = "Home", action = "Index" });
            ////mix static and dynamic segment
            //routes.MapRoute("", "X{controller}/{action}");

            ////using static pattern 'Public'
            //routes.MapRoute("", "Public/{controller}/{action}", new { Controller = "Home", action = "Index" });

            ////routes.Add("MyRoute", myRoute);
            //routes.MapRoute("myRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

        }
    }
}
