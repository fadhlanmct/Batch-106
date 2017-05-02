using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace waBelajarHtml.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Hello = "Selamat datang di MVC5";
            return View();
        }

        public ActionResult Cetak()
        {
            ViewBag.Cetak = "Ini untuk Cetak";
            return View();
        }
    }
}