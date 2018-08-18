using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class HomeController : Controller
    {
        CT464Entities db = new CT464Entities();

        public ActionResult Index()
        {
            var List = db.Products.Where(p => p.CategoryId == 1);
            ViewBag.ListProduct = List;
            var List1 = db.Products.OrderBy(p => p.ProductSold).Where(p => p.CategoryId == 1);
            ViewBag.ListProduct1 = List1;
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
        public ActionResult New_Products()
        {
                     return PartialView();
        }
    }
}