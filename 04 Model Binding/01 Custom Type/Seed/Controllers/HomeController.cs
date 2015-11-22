using Seed.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(bool ?dummy)
        {
            Contact contact = new Contact(123);

            ModelState.AddModelError("fullName", "Bla bnla");

            TryUpdateModel(contact);

            foreach (var entry in ModelState)
            {
                ModelState keyState = entry.Value;
            }

            if (!this.ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index");
        }
    }

    public class Contact : IValidatableObject
    {
        public Contact(int id)
        {
        }

        public int ID { get; set; }

        [Required(ErrorMessageResourceName ="ContactErrorMissingName", ErrorMessageResourceType =typeof(Globals))]
        public string Name { get; set; }

        public string EMail { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
        }
    }
}