using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreKom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "O nas";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt";

            return View();
        }

        public ActionResult Configure()
        {
            ViewBag.Message = "Konfigurator";

            return View();
        }

        public ActionResult Produkty()
        {
            ViewBag.Message = "Produkty";

            return View();
        }
    }
}