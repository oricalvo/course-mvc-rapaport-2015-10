using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GettingStarted.Controllers
{
    public class ContactController : ApiController
    {
        static List<Contact> contacts = new List<Contact>
                {
                    new Contact() { id = 1, name = "Ori" },
                    new Contact() { id = 2, name = "Roni" },
                };

        public Contact[] Get()
        {
            return contacts.ToArray();
        }

        public Contact Post(Contact contact)
        {
            contacts.Add(contact);

            contact.id = contacts.Max(c => c.id) + 1;

            return contact;
        }
    }

    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
