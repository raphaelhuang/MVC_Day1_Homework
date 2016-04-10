using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day1_Homework.ViewModels;

namespace MVC_Day1_Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetAssetList()
        {
            List<AssetViewModel> assetList = new List<AssetViewModel>();

            assetList.Add(new AssetViewModel { Category = false, Date = new DateTime(2016, 1, 1), Money = 300, Description = "" });
            assetList.Add(new AssetViewModel { Category = false, Date = new DateTime(2016, 1, 2), Money = 1600, Description = "" });
            assetList.Add(new AssetViewModel { Category = false, Date = new DateTime(2016, 1, 3), Money = 800, Description = "" });

            return View(assetList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}