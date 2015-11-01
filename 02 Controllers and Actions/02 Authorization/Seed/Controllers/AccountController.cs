using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Seed.Controllers
{
    //[MyAuthorize]
    //[Authorize]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            if (userName == "ori" && password == "123")
            {
                FormsAuthentication.RedirectFromLoginPage(userName, false);

                return null;
            }

            return View();
        }
    }
}