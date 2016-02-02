using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FHR_Data_Access;

namespace Food_Hygiene_Ratings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult Data()
        {
            var proxy = new ServiceProxy("https://data.bathhacked.org/resource/bdxg-pucd.json");
            return new ContentResult { ContentType = "application/json" , Content = proxy.GetAllLocations()};
        }

    }
}