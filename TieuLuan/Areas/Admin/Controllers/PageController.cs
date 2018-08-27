using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TieuLuan.Areas.Admin.Controllers
{
    public class PageController : BaseController
    {
        // GET: Admin/Page
        public ActionResult Index()
        {
            return View();
        }
    }
}