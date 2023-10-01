using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_DoAnNhanh.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Dangnhap()
        {
            return View();
        }

        public ActionResult Dangki()
        {
            return View();
        }
    }
}