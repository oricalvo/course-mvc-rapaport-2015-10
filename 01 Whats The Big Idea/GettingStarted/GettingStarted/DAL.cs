using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GettingStarted
{
    public class DAL
    {
        private static List<Contact> contacts = new List<Contact>()
        {
            new Contact() {UserName="Ori", EMail="ori@gmail.com" },
            new Contact() {UserName="Roni", EMail="roni@gmail.com" },
        };

        public void AddContact(string userName, string email)
        {
            contacts.Add(new Contact()
            {
                UserName = userName,
                EMail = email,
            });
        }

        public Contact[] GetAllContacts()
        {
            return contacts.ToArray();
        }
    }

    public class Contact
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
    }
}