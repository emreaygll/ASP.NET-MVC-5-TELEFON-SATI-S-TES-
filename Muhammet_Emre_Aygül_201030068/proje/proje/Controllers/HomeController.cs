using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proje.Entity;
namespace proje.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }

        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public PartialViewResult _FeaturedUrunList()
        {
            return PartialView(db.Uruns.Where(i => i.IsApproved && i.IsApproved).Take(5).ToList());
        }
        public PartialViewResult Slider()
        {
            return PartialView(db.Uruns.Where(i => i.IsApproved && i.Slider).Take(5).ToList());
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Uruns.Where(i=>i.IsHome&&i.IsApproved).ToList());
        }
        public ActionResult UrunDetay(int id)
        {
            return View(db.Uruns.Where(i=>i.id==id).FirstOrDefault());
        }
        public ActionResult Urun()
        {
            return View(db.Uruns.ToList());
        }
        public ActionResult UrunList(int id)
        {
            return View(db.Uruns.Where(i=>i.Kategoriid==id).ToList());
        }
        public ActionResult Arama(string q)
        {
            var p = db.Uruns.Where(i => i.IsApproved == true);
            if(!string.IsNullOrEmpty(q))
            {
                p = p.Where(i => i.İsim.Contains(q) || i.Acıklama.Contains(q));
            }
            return View(p.ToList());

        }
    }
}