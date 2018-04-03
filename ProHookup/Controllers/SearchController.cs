using System.Linq;
using System.Net;
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
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var professional = db.Professionals.Find(id);
            ViewBag.address = professional.Street + ", " + professional.City + ", " + professional.StateCode;
            return View(professional);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }


    }
}