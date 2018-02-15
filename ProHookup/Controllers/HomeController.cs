using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProHookup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is where we tell you how friggin awesome ProHookup.com is, but it isn't yet. It's under construction give us two or three more sprints" +
                " so we can polish this turd.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is our contact page, but if you call us we will bury you in a shallow grave. Seriously, just wait for version 1.2.";

            return View();
        }
    }
}