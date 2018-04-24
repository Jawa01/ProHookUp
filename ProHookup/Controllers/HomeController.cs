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
            ViewBag.Message =
                "The goal of ProFinder.com is to provide a safe and reliable way for customers to find a professional to complete a desired task. " +
                "We strive to provide the best experinece possible to not only customers but also to the professional who chose to use our services.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}