using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndexWithDeleteButton
{
    public class DAL
    {
        private static List<Contact> contacts = new List<Contact>()
        {
            new Contact() {ID=1, UserName="Ori", EMail="ori@gmail.com" },
            new Contact() {ID=2, UserName="Roni", EMail="roni@gmail.com" },
        };

        public void AddContact(string userName, string email)
        {
            contacts.Add(new Contact()
            {
                UserName = userName,
                EMail = email,
            });
        }

        public Contact GetContactByID(int id)
        {
            return contacts.Where(c => c.ID == id).Single();
        }

        public Contact[] GetAllContacts()
        {
            return contacts.ToArray();
        }

        public void RemoveContactByID(int id)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].ID == id)
                {
                    contacts.RemoveAt(i);
                    return;
                }
            }
        }
    }

    public class Contact
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
    }
}