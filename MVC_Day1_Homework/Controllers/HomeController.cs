using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day1_Homework.ViewModels;
using MVC_Day1_Homework.Models;

namespace MVC_Day1_Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AddRecordService _addRecordSvc;
        public HomeController()
        {
            _addRecordSvc = new AddRecordService();
        }

        public ActionResult Index()
        {
            return View();
        }

        private AssetsModel db = new AssetsModel();

        [ChildActionOnly]
        public ActionResult GetAssetList()
        {
            var accountBook = db.AccountBook.OrderByDescending(x => x.Dateee).Take(10);

            return View(accountBook);
        }

        [HttpPost]
        public ActionResult Addrecord(AssetViewModel assetViewModel)
        {
            var accountBook = new AccountBook();

            if (ModelState.IsValid)
            {
                accountBook.Id = Guid.NewGuid();
                accountBook.Categoryyy = assetViewModel.Category;
                accountBook.Dateee = assetViewModel.Date;
                accountBook.Amounttt = (int)assetViewModel.Money;
                accountBook.Remarkkk = assetViewModel.Description;

                _addRecordSvc.AddRecord(accountBook);
                _addRecordSvc.Save();

                return View("Index");
            }
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //if (HttpContext.User.Identity.Name == "user@user.user")
            if(User.IsInRole("Admin"))
            {
                return RedirectToActionPermanent("Index", "Admin", new { Area = "Backend" });
            }

            //redirect to Homepage if not login
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}