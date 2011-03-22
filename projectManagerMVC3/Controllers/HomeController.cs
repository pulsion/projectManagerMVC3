using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectManagerMVC3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Pulsion Project Manager written using ASP.NET MVC 3!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
