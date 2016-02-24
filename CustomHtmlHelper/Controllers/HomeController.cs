using CustomHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Usuario {
                Nombre = "Juan"
            });
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