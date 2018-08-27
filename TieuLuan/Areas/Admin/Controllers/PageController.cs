using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;
namespace TieuLuan.Areas.Admin.Controllers
{
    public class PageController : BaseController
    {
        CT464Entities db = new CT464Entities();
        // GET: Admin/Page
        public ActionResult Index()
        {
            //Số lượng nhân viên
            var List = db.Employees.Count();
            ViewBag.ListCount = List;
            //Số lượng sản phẩm
            var ListProduct =
                (from p in db.Products
                select p).Count();
            ViewBag.ListProduct = ListProduct;
            //Tổng danh thu
            // var total = (
            //     from p in db.OrderDetails
            //     select p.Quantity * p.SoldPrice
            //     ).Sum();
            //ViewBag.total = total;
            //Người dùng
            var contact = db.Contacts.Where(x => x.Status == true).Count();
            ViewBag.contact = contact;
            //Khuyến mãi
            var promotionActive = (from p in db.Promotions where p.PromotionStatus == true select p).Count();
            ViewBag.promotionActive = promotionActive;
            return View();
        }
    }
}