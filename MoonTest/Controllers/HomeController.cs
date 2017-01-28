using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoonTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Moonbeam Cinemas";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Want to reach me?";

            return View();
        }
    }
}