using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lec09.Controllers
{
    public class HomeController : Controller
    {
        public static string Nombre = "Rodolfo";
        public string Apellido = "Conejo";

        public ActionResult Index()
        {
            ViewBag.Prueba = "Nueva Variable";
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
    }
}