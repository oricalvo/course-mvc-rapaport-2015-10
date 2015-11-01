using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.MvcControllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeIndexModel model = new HomeIndexModel()
            {
                Contacts = new DAL().GetContacts(),
                OrderByDesc = true,
            };

            return View(model.Contacts);
        }
    }

    public class HomeIndexModel
    {
        public Contact[] Contacts { get; set; }
        public bool OrderByDesc { get; set; }
    }

    public class DAL
    {
        public Contact[] GetContacts()
        {
            return new Contact[] {
                new Contact() {ID=1, Name="ori" },
                new Contact() {ID=2, Name="roni" },
            };
        }
    }

    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}