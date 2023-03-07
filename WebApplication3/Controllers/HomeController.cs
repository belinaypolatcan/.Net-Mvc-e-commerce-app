using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication3.Models.entity;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        MvcDbStokEntities db = new MvcDbStokEntities();
        [Authorize]
        
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }

        public ActionResult Kadin()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
        public ActionResult Erkek()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
        public ActionResult AnneCocuk()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
        public ActionResult EvMobilya()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
        public ActionResult Ayakkabi()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);

        }
        public ActionResult Canta()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
        public ActionResult Hesabim()
        {
            var degerler = db.TBLMUSTERILER.ToList();
            return View(degerler);
        }

        public ActionResult Sepetim()
        {
            var degerler = db.TBLSATISLAR.ToList();
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Index(TBLMUSTERILER p)
        {
            Context c = new Context();
            var bilgiler = c.TBLMUSTERILER.FirstOrDefault(x => x.MUSTERIMAIL == p.MUSTERIMAIL && x.MUSTERISIFRE == p.MUSTERISIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MUSTERIMAIL, false);
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
            
        }

    }




}
}