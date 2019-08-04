using System.Linq;
using System.Web.Mvc;
using TieuLuan.Models;
using TieuLuan.Areas.Admin.Models;
namespace TieuLuan.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = CheckRegister(model.EmployeeCode, model.EmployeePass);
                if (result)
                {
                    Session["username"] = model.EmployeeCode;
                    return RedirectToAction("Index", "Page");

                }
                else
                {
                    ModelState.AddModelError("", "Vui lòng kiểm tra tài khoản và mật khẩu!");
                }
            }
            return View("Login");
        }
        public static bool CheckRegister(string username, string password)
        {
            //var pass = Encrypt.MD5_Encode(password);


            var encrpytedPassword = Encrypt.MD5_Encode(password);
            using (CT464Entities db = new CT464Entities())
            {
                var singin = from p in db.Employees
                             where p.EmployeeCode == username && p.EmployeePass == encrpytedPassword
                             select p;
                return singin.Any();
            }

        }
        public ActionResult LogOff()
        {
            Session["username"] = null;
            return RedirectToAction("Login", "Login");
        }
    }
}