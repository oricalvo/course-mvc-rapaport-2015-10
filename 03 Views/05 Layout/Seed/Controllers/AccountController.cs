using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult HelloUser()
        {
            var model = new AccountHelloUserModel()
            {
                UserName = "Ori",
            };

            return PartialView(model);
        }
    }

    public class AccountHelloUserModel
    {
        public string UserName { get; set; }
    }
}