using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using proje.Entity;

namespace proje.Controllers
{
    public class HesapController : Controller
    {
        // GET: Hesap
        DataContext c = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanici p)
        {
            var bilgiler = c.Kullanicis.FirstOrDefault(x => x.admin == p.admin && x.sifre == p.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.admin, true);
                Session["admin"] = bilgiler.admin.ToString();
                Session["sifre"] = bilgiler.sifre.ToString();
                return RedirectToAction("Index", "Kategori");
            }
            else
            {
                return RedirectToAction("Index", "Kategori");
            }
        }
}
}