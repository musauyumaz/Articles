using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRadio.Models;

namespace TestRadio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.list = FillListModel();
            return View(FillRoleModel());
        }

        [HttpPost]
        public ActionResult Index(List<RoleModel> roleModels)
        {
            if (ModelState.IsValid) {
                return Content("Data Saved");
            }
            else
            {
                return Content("Data Error");
            }
        }

        private List<RoleModel> FillRoleModel()
        {
            List<RoleModel> datas = new List<RoleModel>()
            {
                new RoleModel(){Id=1,Description="Uygulama Yönetim Ekranları", IsAllow= true, Name="Administrator"},
                new RoleModel(){Id=2,Description="Giriş Yapabilen Tüm Kullanıcılar", IsAllow= false, Name="CommonScreens"},
                new RoleModel(){Id=3,Description="Ajans Silme", IsAllow= true, Name="AgencyDelete"},
                new RoleModel(){Id=4,Description="Ajans Detayı Görme", IsAllow= true, Name="AgencyDetail"}
            };

            return datas;
        }

        private List<ListModel> FillListModel()
        {
            List<ListModel> Datas = new List<ListModel>()
            {
                new ListModel(){Id=1,Text = "Worse"},
                new ListModel(){Id=2,Text = "Bad"},
                new ListModel(){Id=3,Text = "Good"},
                new ListModel(){Id=4,Text = "Better"},
                new ListModel(){Id=5,Text = "Best"}
            };
            return Datas;
        }
    }
}