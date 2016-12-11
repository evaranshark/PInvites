using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInvites.Controllers
{
    public class AnotherController : Controller
    {
        // GET: Another
        public ActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }
    }
}