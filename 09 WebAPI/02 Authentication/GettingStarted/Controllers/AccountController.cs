using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace GettingStarted.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public void SignIn(Login login)
        {
            FormsAuthentication.SetAuthCookie(login.UserName, false);
        }

        [HttpPost]
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }

    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
