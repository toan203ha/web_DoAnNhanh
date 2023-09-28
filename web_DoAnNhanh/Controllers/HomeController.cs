using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_DoAnNhanh.Controllers
{
    public class HomeController : Controller
    {
      

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
        // chi tiet san pham
        public ActionResult details()
        {
            return View();
        }
        // trang chu
        public ActionResult Index()
        {
            return View();
        }
        // gio hang chua co san pham nao
        public ActionResult CartNoProduct()
        {
            return View();
        }
        // gio hang da co san pham
        public ActionResult CartProduct()
        {
            return View();
        }

        // danh sách sản phẩm
        public ActionResult ViewSanPham()
        {
            return View();
        }



    }
}