using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

            //return File(
        }

        [ActionName("Run")]
        [Form("button1")]
        public ActionResult Run1()
        {
            return View("Run1");
        }

        [ActionName("Run")]
        [Form("button2")]
        public ActionResult Run2()
        {
            return View("Run2");
        }
    }

    public class FormAttribute : ActionMethodSelectorAttribute
    {
        private string field;

        public FormAttribute(string field)
        {
            this.field = field;
        }

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            bool res = (controllerContext.HttpContext.Request.Form[this.field] != null);
            return res;
        }
    }
}