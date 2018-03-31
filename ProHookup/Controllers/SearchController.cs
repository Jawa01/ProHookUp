using System.Linq;
using System.Web.Mvc;
using ProHookup.Models;

namespace ProHookup.Controllers
{
    public class SearchController : Controller
    {
        private readonly ProFinderDBEntities2 db = new ProFinderDBEntities2();

        [HttpPost]
        public ActionResult Index(string input)
        {
            ViewBag.term = input;
            return View(db.Professionals.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}