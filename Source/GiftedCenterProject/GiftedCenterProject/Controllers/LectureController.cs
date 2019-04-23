using GiftedCenterProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftedCenterProject.Controllers
{
    public class LectureController : Controller
    {
        Connect cnn = new Connect();
        // GET: Lecture
        public ActionResult Index()
        {
            var lecturer = from a in cnn.Lecturer
                           where a.isActive.Equals(1)
                           select a;
            if(lecturer!= null)
            {
                return View(lecturer.ToList());
            }
            return View();

            var countLecturer = (from count in cnn.Lecturer
                                 where count.isActive.Equals(1)
                                 select count).Count();
            
        }


    }
}