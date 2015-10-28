using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndexWithDeleteButton.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index(string firstName, string lastName, int maxAge)
        {
            DAL dal = new DAL();
            Contact[] contacts = dal.GetAllContacts();

            return View(contacts);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            DAL dal = new DAL();
            Contact contact = dal.GetContactByID(id);

            return View(contact);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DAL dal = new DAL();
            dal.RemoveContactByID(id);

            return RedirectToAction("Index");
        }
    }
}