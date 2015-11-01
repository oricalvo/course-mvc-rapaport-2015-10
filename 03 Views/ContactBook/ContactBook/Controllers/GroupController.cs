using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactBook.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index(int? id)
        {
            Group group = new DAL().FindGroupByID(id);

            GroupModel model = new GroupModel()
            {
                ID = group.ID,
                Name = group.Name,
                ParentID = group.ParentID,
                Items = group.Items.Select(item =>
                {
                    return new BookItemModel()
                    {
                        ID = item.ID,
                        DisplayName = item.DisplayName,
                        IsGroup = (item is Group),
                    };
                }).ToList()
            };

            return View(model);
        }
    }

    public class GroupModel
    {
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string Name { get; set; }
        public List<BookItemModel> Items { get; set; }
    }

    public class BookItemModel
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public bool IsGroup { get; set; }
    }
}