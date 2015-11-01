using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    //[MyAuthorize]
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
    }

    public class MyAuthorizeAttribute : FilterAttribute, IAuthorizationFilter, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            //{
            //    filterContext.Result = new RedirectResult("/Account/Login");
            //}
        }
    }
}