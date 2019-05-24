using GiftedCenterProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftedCenterProject.Controllers
{
    public class CategoryController : Controller
    {
        Connect cnn = new Connect();
        // GET: Category
        public ActionResult Index()
        {
            var query = from c in cnn.GroupSubject
                        where c.isActive.Equals(1)
                        select c;
            if (query != null)
            {
                return View(query.ToList());
            }
            return View();
        }
    }
}