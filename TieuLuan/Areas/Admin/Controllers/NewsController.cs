using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;
using System.IO;
namespace TieuLuan.Areas.Admin.Controllers
{
    public class NewsController : BaseController
    {
        private CT464Entities db = new CT464Entities();

        // GET: Admin/News
        public ActionResult Index()
        {
            var news = db.News.Include(n => n.Employee);
            return View(news.ToList());
        }

        // GET: Admin/News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // GET: Admin/News/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName");
            return View();
        }

        // POST: Admin/News/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NewsId,NewTitles,NewsDetails,NewsBy,NewsDate,EmployeeCode")] News news)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.News.Add(news);
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

            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName", news.EmployeeCode);
            return View(news);
        }

        // GET: Admin/News/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName", news.EmployeeCode);
            return View(news);
        }

        // POST: Admin/News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NewsId,NewTitles,NewsDetails,NewsBy,NewsDate,EmployeeCode")] News news)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(news).State = EntityState.Modified;
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
            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName", news.EmployeeCode);
            return View(news);
        }

        // GET: Admin/News/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // POST: Admin/News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            News news = db.News.Find(id);
            db.News.Remove(news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Upload
        public ActionResult UploadNews(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var news = db.News.Include(s => s.ImgNews).SingleOrDefault(p => p.NewsId == id);
            if (news == null)
            {
                object Err = "Information not find";
                return View("Error", Err);
            }
            return View(news);
        }
        [HttpPost]
        public ActionResult UploadNews(int id, HttpPostedFileBase[] files)
        {
            byte max = 0;
            var listImg = db.ImgNews.Where(p => p.NewsId == id).ToList();
            if (listImg.Count > 0)
                max = listImg.Max(p => p.SortNews);
            var listFile = files.Where(p => p != null);
            foreach (var f in listFile)
            {
                //Tạo một đối tượng
                var img = new ImgNew();
                
                img.NewsId= id;
                img.NewsImg = f.FileName;
                img.SortNews = ++max;
                db.ImgNews.Add(img);
                var path = Server.MapPath("~/ImgUI/News/" + f.FileName);
                f.SaveAs(path);
            }
            if (listFile.Any())
                db.SaveChanges();
            return RedirectToAction("UploadNews");
        }

        public ActionResult DeleteImg(int id, int? NewsId)
        {
            if (NewsId.HasValue)
            {
                try
                {
                    var img = db.ImgNews.Find(id);
                    if (img == null)
                        return RedirectToAction("Index");
                    db.ImgNews.Remove(img);
                    var fileName = img.NewsImg;
                    var path = Server.MapPath("~/ImgUI/News/" + fileName);
                    var file = new FileInfo(path);

                    if (file.Exists)
                    {
                        file.Delete();
                    }

                    db.SaveChanges();
                    return RedirectToAction("UploadNews");
                }

                catch (Exception ex)
                {
                    object mess = "Can not Delete IMG " + ex.Message;
                    return View("Error", mess);
                }
            }

            TempData["Success_Mess"] = "<script>alert('Delete Success')</script>";
            return Redirect("~/News/UploadNews/" + NewsId);
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
