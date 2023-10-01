using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_DoAnNhanh.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Info()
        {
            return View();
        }
        public ActionResult ViewKhuyenmai()
        {
            return View();
        }
    }
}