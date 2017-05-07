using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrNiyatiPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Laser Asthetica.in by Dr Niyati | Cosmetologist & Laser Physician";
            return View();
        }

        public ActionResult About(QueryStringValueProvider values)
        {
            ViewBag.Message = "Your application description page.";

            var v = values.GetValue("");
            var d = Request.QueryString[""];
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}