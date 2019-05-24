using GiftedCenterProject.Data;
using GiftedCenterProject.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftedCenterProject.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        Connect cnn = Util.Util.cnn;
        public ActionResult Index()
        {
            var query = from cl in cnn.Class
                        where cl.isActive.Equals(Util.Util.ISACTIVE)
                        select cl;
            if(query!=null&& query.Count() > 0)
            {
                return View(query.ToList());
            }
            return View();
        }
    }
}