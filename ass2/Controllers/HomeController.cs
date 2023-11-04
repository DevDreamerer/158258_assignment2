using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ass2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Problem()
        {
            ViewBag.Message = "Your Problem page.";
            return View();
        }

        public ActionResult Protection()
        {
            ViewBag.Message = "Your Protection page.";
            return View();
        }
    }
}