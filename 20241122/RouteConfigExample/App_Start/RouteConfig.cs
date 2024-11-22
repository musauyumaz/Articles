using RouteConfigExample.CustomSelectors;
using System.Web.Mvc;
using System.Web.Routing;

namespace RouteConfigExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Filter4", 
            url: "Home/IndexExplorer/{id}",
            defaults: new { controller = "Home", action = "IndexExplorer", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "BrowserFilter",
                url: "Home/ActionSelector/{id}",
                defaults: new { controller = "Home", action = "ActionSelectorFilteredBrowser", id = UrlParameter.Optional },
                constraints: new { userAgent = new UserAgentSelector("Microsoft Edge"), id = @"[1-6]" });

            routes.MapRoute(
                name: "Filter2", //Route name
                url: "Home/ActionSelector/{id}",
                defaults: new { controller = "Home", action = "ActionSelectorFiltered", id = UrlParameter.Optional },
                constraints: new { id = @"[1-6]" }); // Url with parameters
            #region Filter2 Note
            //Yukarıda route.config’e yeni bir constraint ekledik.Bu constraintde regex ile gelen id parametresi 1 ile 6 arasında olması gerektiği belirtilmiştir. Eğer Url’e: http://localhost:4443/Home/ActionSelector/6 yazar isek id değeri olan 6, kural’a uyduğu için ActionSelectorFiltered sayfasına gider. Eğer http://localhost:4443/Home/ActionSelector/8  yazar isek id değeri 8, 1 ile 6 arasında olamığı ve kurala uymadığı için bir altındaki route olan ActionSelector’e gider.
            #endregion
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Filter", //Route name
                url: "Home/ActionSelector/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }); // Url with parameters
        }
    }
}
#region Filter Note
//Url’den request gelince RouteHandler devreye girer.Routing her zaman RouteConfig’de, istemciden gelen url’e uyan route’u en üstten aşşağıya doğru tarayarak bakar.En sona en genel route yani default route konur.Aranan koşullara uygunluk, url segmesinden bakıldıktan sonra, eğer geçerli koşullar sağlanmış ise ilgli controller’ın ilgili action’a gidilir.Test amaçlı  yukarıdaki RoutConfig örneğinde Url kısmına http://localhost:4443/Home/ActionSelector yazarsak Filter Route’una gidecektir. http://localhost:4443/Home/ yazarsak Default route’una gidecektir.
#endregion