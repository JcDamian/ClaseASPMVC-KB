using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaseASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Nuestros Servicios.";

            return View();
        }

        public ActionResult Galery()
        {
            ViewBag.Message = "Galería de la empresa.";

            return View();
        }

        [ActionName ("Hora")]
        public string HoraActual()
        {
            return DateTime.Now.ToString("T");
        }
    }
}