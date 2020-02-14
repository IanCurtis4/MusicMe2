using System.Web.Mvc;
using System.Web.Routing;

namespace MusicMe2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Likes/Create",
            //    url: "Likes/Create/{postId}/{commentId}",
            //    defaults: new { controller = "Likes", action = "Create", postId = UrlParameter.Optional, commentId = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Likes/Delete",
            //    url: "Likes/Delete/{id}/{postId}/{commentId}",
            //    defaults: new { controller = "Likes", action = "Delete", id = UrlParameter.Optional, postId = UrlParameter.Optional, commentId = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Shares/Create",
            //    url: "Shares/Create/{postId}",
            //    defaults: new { controller = "Likes", action = "Create", postId = UrlParameter.Optional}
            //);

            //routes.MapRoute(
            //    name: "Shares/Delete",
            //    url: "Shares/Delete/{id}/{postId}",
            //    defaults: new { controller = "Likes", action = "Delete", id = UrlParameter.Optional, postId = UrlParameter.Optional}
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
