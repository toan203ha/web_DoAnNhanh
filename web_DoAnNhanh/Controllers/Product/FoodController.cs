using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_DoAnNhanh.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult ViewFood()
        {
            return View();
        }
    }
}