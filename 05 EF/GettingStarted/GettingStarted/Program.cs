using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();

            User[] users = context.Users.ToArray();
            foreach (var user in users)
            {
                Console.WriteLine(user.ID + ", " + user.Name);
            }
        }
    }

    class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyContext() : base("MyDB2")
        {
        }
    }

    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public Group Group { get; set; }
    }

    class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
