using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day1_Homework.Filter
{
    public class AuthorizeAjaxAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.Result is HttpUnauthorizedResult && filterContext.HttpContext.Request.IsAjaxRequest())
            {
                ContentResult cr = new ContentResult();
                cr.Content = "<p style=\"color:Red;font-weight:bold;\">您尚未登入無法觀看!! 請先登入後再嘗試。</p>";
                filterContext.Result = cr;
            }
        }
    }
}