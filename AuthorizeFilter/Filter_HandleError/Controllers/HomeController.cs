using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter_HandleError.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HandleError]
        public ActionResult Index()
        {
            //return View();
            //try
            //{
                throw new Exception("expception come");

            //}
            //catch
            //{
            //    return RedirectToAction("Index", "Error");
            //}
        }
    }
}