using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GettingStarted.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index(string userName, string email)
        {
            DAL dal = new DAL();
            ContactModel[] contacts = dal.GetAllContacts().Select(c => new ContactModel()
            {
                UserName = c.UserName,
                EMail = c.EMail,
                IsOldest = true,
            }).ToArray();

            return View(contacts);
        }

        public ActionResult Create(string userName, string email)
        {
            DAL dal = new DAL();
            dal.AddContact(userName, email);

            return RedirectToAction("Index");
        }
    }

    public class ContactModel
    {
        public string UserName { get; set; }
        public string EMail { get; set; }
        public bool IsOldest { get; set; }
    }
}