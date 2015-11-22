using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.CreateMap<Contact, ContactModel>().AfterMap((contact, model) =>
            {
                //model.DisplayName = contact.Name + ", " + contact.EMail;
            });

            Mapper.CreateMap<DataRow, ContactModel>().ConvertUsing(row =>
            {
                return new ContactModel()
                {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"]
                };
            });

            Contact c = new Contact()
            {
                ID = 1,
                Name = "Ori",
                IsAdmin = true,
            };

            ContactModel model = Mapper.Map<ContactModel>(c);
        }
    }

    class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
    }

    class ContactModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
