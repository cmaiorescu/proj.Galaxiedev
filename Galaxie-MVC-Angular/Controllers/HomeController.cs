using Galaxie_MVC_Angular.Dapper;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Galaxie_MVC_Angular.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(tblItem Item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Home");
            }
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Query()
        {
            return View();
        }
    }
}
