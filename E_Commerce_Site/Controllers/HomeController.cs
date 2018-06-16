using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce_Site.Models;

namespace E_Commerce_Site.Controllers
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

        public ActionResult DynamicMenu()
        {
            var categories = new List<subHeadingModels>
            {
            new subHeadingModels {name="Men" },
            new subHeadingModels {name="Women" },
            new subHeadingModels {name="Child" },
            new subHeadingModels {name="Men Accesories" },
            new subHeadingModels {name="Women Accesories" }
        };


            return PartialView("_subMenu",categories);
        }
    }
}