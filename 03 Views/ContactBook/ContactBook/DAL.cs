using ContactBook.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactBook
{
    public abstract class BookItem
    {
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public abstract string DisplayName { get; }
    }

    public class Contact : BookItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public override string DisplayName
        {
            get
            {
                return this.Name + ", " + this.Email;
            }
        }
    }

    public class Group : BookItem
    {
        public string Name { get; set; }
        public List<BookItem> Items { get; set; }
        public override string DisplayName
        {
            get
            {
                return this.Name;
            }
        }
    }

    public class DAL
    {
        static Group root = new Group()
        {
            ID = 1,
            Name = "~",
            ParentID = null,
            Items = new List<BookItem>()
                {
                    new Group()
                    {
                        ID=2,
                        Name = "Friends",
                        Items = new List<BookItem>()
                        {
                            new Group()
                            {
                                ID=7,
                                Name = "Best Friends",
                                Items = new List<BookItem>(),
                                ParentID = 2,
                            },
                            new Contact()
                            {
                                ID =6,
                                Name ="Roni",
                                Email ="roni@gmail.com",
                                ParentID = 2,
                            }
                        },
                        ParentID = 1,
                    },
                    new Group()
                    {
                        ID=3,
                        Name = "Co-Workers",
                        Items = new List<BookItem>(),
                        ParentID = 1,
                    },
                    new Contact()
                    {
                        ID=4,
                        Name = "Ori Calvo",
                        Email = "ori@gamil.com",
                        ParentID = 1,
                    },
                    new Contact()
                    {
                        ID=5,
                        Name = "Udi Cohen",
                        Email = "udi@gamil.com",
                        ParentID = 1,
                    },
                }
        };

        public Group FindGroupByID(int? id)
        {
            if (id == null || id == 1)
            {
                return root;
            }
            else
            {
                return FindGroupByID(root, id.Value);
            }
        }

        public Group FindGroupByID(Group parent, int id)
        {
            foreach (var item in parent.Items)
            {
                if (item is Group)
                {
                    Group g = (Group)item;
                    if (g.ID == id)
                    {
                        return g;
                    }

                    var res = FindGroupByID(g, id);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }

            return null;
        }
    }
}