using RouteConfigExample.CustomAttributes;
using RouteConfigExample.CustomFilters;
using System.Web.Mvc;

namespace RouteConfigExample.Controllers
{
    public class HomeController : Controller
    {
        [WriteSteps("Anasayfa")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ActionSelector()
        {
            return View();
        }

        [Explorer]
        [WriteSteps("Explorer", Order = 1)]
        [WriteSteps("2.Index", Order = 2)]
        public ActionResult IndexExplorer()
        {
            return View("IndexExplorer");
        }

    }
}