using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sanita.Models;

namespace Sanita.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {

            List<Banner> Banners = db.Banners.ToList();
            return View(Banners);

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
