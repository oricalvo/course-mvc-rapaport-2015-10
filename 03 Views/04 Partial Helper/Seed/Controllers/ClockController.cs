using Seed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    public class ClockController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ClockModel model = new ClockModel()
            {
                TATime = DateTime.Now
            };

            return View(model);
        }
    }
}