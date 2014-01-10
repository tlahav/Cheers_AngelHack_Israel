using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cheers_A02.Models;

namespace Cheers_A02.Controllers
{
    [Serializable]
    public class MyObject
    {
        public string guidTable { get; set; }
        public string guidPerson { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Cheers!";

            return View();
        }

        public ActionResult CheckIn(string strTableGuid)
        {
            Utilities util = new Utilities();
            int count = 0;
            Guid guidTable = Guid.Parse(strTableGuid);
            

            //util.CheckInTable(guidTable,ref count);
            RestaurantManager restMang = new RestaurantManager();
            var restaurant = restMang.GetRestaurant(guidTable);
            ViewBag.imageURL = restaurant.LogoImageURL;
            ViewBag.restName = restaurant.RestName;
            ViewBag.checkinCount = count;
            ViewBag.guidTable = guidTable;
            return View();
        }
        

        [HttpPost]
        public JsonResult AJAXCheckIn(MyObject x)
        {
            Utilities util = new Utilities();
            int count = 0;
            Guid guidTable = Guid.Parse(x.guidTable);
            Guid guidPerson = Guid.Parse(x.guidTable);
            util.CheckInTable(guidPerson, guidTable, ref count);

            return Json(count);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
