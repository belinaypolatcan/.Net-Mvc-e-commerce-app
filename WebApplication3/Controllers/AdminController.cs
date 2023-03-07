using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models.entity;

namespace WebApplication3.Controllers
{
    
    public class AdminController : Controller
    {
  


        // GET: Admin

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLMUSTERILER p)
        {
            Context c = new Context();
            var bilgiler = c.TBLMUSTERILER.FirstOrDefault(x => x.MUSTERIMAIL == p.MUSTERIMAIL && x.MUSTERISIFRE == p.MUSTERISIFRE);
            if (bilgiler != null) {
                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }


}