using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_DoAnNhanh.Controllers
{
    public class DrinksController : Controller
    {
        // GET: Drinks
        public ActionResult ViewDrinks()
        {
            return View();
        }
    }
}