using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day1_Homework.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult Index(DateTime date)
        {
            bool isValidate = date >= DateTime.Today;

            return Json(isValidate, JsonRequestBehavior.AllowGet);

        }
    }
}