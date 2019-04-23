using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftedCenterProject.Data;

namespace GiftedCenterProject.Controllers
{
    public class LoginController : Controller
    {
        Connect cnn = new Connect();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public int Login(string Username, string Password)
        {
            var query = from a in cnn.Account
                        where a.accountName.Equals(Username) && a.passWord.Equals(Password)
                        select a;
            var result = query.ToList();
            if(result!= null)
            {
                return 1;
            }

            return 0;
        }
    }
}