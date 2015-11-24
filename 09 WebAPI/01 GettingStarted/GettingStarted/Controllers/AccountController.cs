using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GettingStarted.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public void SignIn(string userName, string password)
        {
        }

        [HttpPost]
        public void SignOut()
        {
        }
    }
}
