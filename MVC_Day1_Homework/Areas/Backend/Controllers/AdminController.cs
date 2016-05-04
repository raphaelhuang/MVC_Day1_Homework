using MVC_Day1_Homework.Models;
using MVC_Day1_Homework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day1_Homework.Areas.Backend.Controllers
{
    public class AdminController : Controller
    {
        private readonly AddRecordService _addRecordSvc;
        public AdminController()
        {
            _addRecordSvc = new AddRecordService();
        }

        private AssetsModel db = new AssetsModel();

        // GET: Backend/Admin
        public ActionResult Index()
        {

            var accountBook = db.AccountBook.OrderByDescending(x => x.Dateee).Take(10);
            return View(accountBook);
        }

        public ActionResult EditRecord(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Guid deleteGuid = new Guid();
            Guid.TryParse(id, out deleteGuid);

            AccountBook accountBook = db.AccountBook.Find(deleteGuid);
            if (accountBook == null)
            {
                return HttpNotFound();
            }

            AssetViewModel avm = new AssetViewModel();
            avm.Category = accountBook.Categoryyy;
            avm.Money = accountBook.Amounttt;
            avm.Date = accountBook.Dateee;
            avm.Description = accountBook.Remarkkk;

            return View(avm);
        }

        [HttpPost]
        public ActionResult EditRecord(AccountBook accountBook, AssetViewModel assetViweModel)
        {
            var oldData = _addRecordSvc.GetSingle(accountBook.Id);

            accountBook.Categoryyy = assetViweModel.Category;
            accountBook.Amounttt = (int)(assetViweModel.Money);
            accountBook.Dateee = assetViweModel.Date;
            accountBook.Remarkkk = assetViweModel.Description;

            if (oldData != null)
            {
                _addRecordSvc.EditRecord(accountBook, oldData);
                _addRecordSvc.Save();

                return RedirectToAction("Index");
            }

            return View(assetViweModel);
        }


        public ActionResult DeleteRecord(string record)
        {
            Guid deleteGuid = new Guid();
            Guid.TryParse(record, out deleteGuid);

            _addRecordSvc.DeleteRecord(deleteGuid);
            _addRecordSvc.Save();

            return RedirectToAction("index");
        }
    }
}