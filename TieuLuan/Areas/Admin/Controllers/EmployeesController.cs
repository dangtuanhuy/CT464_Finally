using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Areas.Admin.Controllers
{
    public class EmployeesController : BaseController
    {
        private CT464Entities db = new CT464Entities();

        // GET: Admin/Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Role);
            return View(employees.ToList());
        }

        // GET: Admin/Employees/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Admin/Employees/Create
        public ActionResult Create()
        {
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "RoleName");
            return View();
        }

        // POST: Admin/Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeCode,EmployeePass,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,PostalCode,HomePhone,Extension,Notes,RoleId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employee.EmployeePass = Encrypt.MD5_Encode(employee.EmployeePass);
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(db.Roles, "Id", "RoleName", employee.RoleId);
            return View(employee);
        }

        // GET: Admin/Employees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "RoleName", employee.RoleId);
            return View(employee);
        }

        // POST: Admin/Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeCode,EmployeePass,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,PostalCode,HomePhone,Extension,Notes,RoleId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "RoleName", employee.RoleId);
            return View(employee);
        }

        // GET: Admin/Employees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Admin/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Upload hình nhân viên nè
        public ActionResult UploadEmployee(string id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var employee = db.Employees.Include(s => s.ImgEmps).SingleOrDefault(p => p.EmployeeCode == id);
            if(employee == null)
            {
                object err = "Thông tin truy cập không tồn tại";
                return View("Error", err);
            }
            return View(employee);
        }
        [HttpPost]
        public ActionResult UploadEmployee(string id, HttpPostedFileBase[] files)
        {
            byte max = 0;
            var listImg = db.ImgEmps.Where(p => p.EmployeeCode == id).ToList();
            if (listImg.Count > 0)
                max = listImg.Max(p => p.SortEmp);
            var listFile = files.Where(p => p != null);
            foreach (var f in listFile)
            {
                var img = new ImgEmp();
                img.EmployeeCode = id;
                img.EmployeeImg = f.FileName;
                img.SortEmp = ++max;
                db.ImgEmps.Add(img);
                var path = Server.MapPath("~/ImgUI/Emp/" + f.FileName);
                f.SaveAs(path);
            }
            if (listFile.Any())
                db.SaveChanges();
            return RedirectToAction("UploadEmployee");
        }
        public ActionResult DeleteImg(int id, string EmployeeCode)
        {
            if (EmployeeCode != null)
            {
                try
                {
                    var img = db.ImgEmps.Find(id);
                    if (img == null)
                        return RedirectToAction("Index");
                    db.ImgEmps.Remove(img);
                    var fileName = img.EmployeeImg;
                    var path = Server.MapPath("~/ImgUI/Emp/" + fileName);
                    var file = new FileInfo(path);

                    if (file.Exists)
                    {
                        file.Delete();
                    }

                    db.SaveChanges();
                    return RedirectToAction("UploadEmployee");
                }

                catch (Exception ex)
                {
                    object mess = "Can not Delete IMG " + ex.Message;
                    return View("Error", mess);
                }
            }

            TempData["Success_Mess"] = "<script>alert('Delete Success')</script>";
            return Redirect("~/Products/UploadEmployee/" + EmployeeCode);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
