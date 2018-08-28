using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;
using System.IO;
namespace TieuLuan.Areas.Admin.Controllers
{
    public class DeliveriesController : BaseController
    {
        private CT464Entities db = new CT464Entities();

        // GET: Admin/Deliveries
        public ActionResult Index()
        {
            var deliveries = db.Deliveries.Include(d => d.Employee);
            return View(deliveries.ToList());
        }

        // GET: Admin/Deliveries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery delivery = db.Deliveries.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            return View(delivery);
        }

        // GET: Admin/Deliveries/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName");
            return View();
        }

        // POST: Admin/Deliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeliveryId,DeliveryTitle,DeliveryDetails,DeliveryQuestion,EmployeeCode")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                db.Deliveries.Add(delivery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName", delivery.EmployeeCode);
            return View(delivery);
        }

        // GET: Admin/Deliveries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery delivery = db.Deliveries.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName", delivery.EmployeeCode);
            return View(delivery);
        }

        // POST: Admin/Deliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeliveryId,DeliveryTitle,DeliveryDetails,DeliveryQuestion,EmployeeCode")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(delivery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeCode = new SelectList(db.Employees, "EmployeeCode", "FirstName", delivery.EmployeeCode);
            return View(delivery);
        }

        // GET: Admin/Deliveries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Delivery delivery = db.Deliveries.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            return View(delivery);
        }

        // POST: Admin/Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Delivery delivery = db.Deliveries.Find(id);
            db.Deliveries.Remove(delivery);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Xử lý hình ảnh
        public ActionResult UploadDelivery(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var delivery = db.Deliveries
                .Include(s => s.ImgDeliveries)
                .SingleOrDefault(p => p.DeliveryId == id);
            if (delivery == null)
            {
                object err = "Thông tin truy cập không tồn tại!";
                return View("Error", err);
            }
            return View(delivery);
        }

        /// <summary>
        /// </summary>
        /// <param name="id">compare id of img with source</param>
        /// <param name="files">allow to upload file img</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UploadDelivery(int id, HttpPostedFileBase[] files)
        {
            byte max = 0;
            var listImg = db.ImgDeliveries.Where(p => p.DeliveryId == id).ToList();
            if (listImg.Count > 0)
                max = listImg.Max(p => p.SortDeli);
            var listFile = files.Where(p => p != null);
            foreach (var f in listFile)
            {
                var img = new ImgDelivery();
                img.DeliveryId = id;
                img.DeliveryImg = f.FileName;
                img.SortDeli = ++max;
                db.ImgDeliveries.Add(img);
                var path = Server.MapPath("~/ImgUI/Deli/" + f.FileName);
                f.SaveAs(path);
            }
            if (listFile.Any())
                db.SaveChanges();
            return RedirectToAction("UploadDelivery", new { id });
        }


        public ActionResult DeleteImg(int id, int? DeliveryId)
        {
            if (DeliveryId.HasValue)
            {
                try
                {
                    var img = db.ImgDeliveries.Find(id);
                    if (img == null)
                        return RedirectToAction("Index");
                    db.ImgDeliveries.Remove(img);
                    var fileName = img.DeliveryImg;
                    var path = Server.MapPath("~/ImgUI/Deli/" + fileName);
                    var file = new FileInfo(path);

                    if (file.Exists)
                    {
                        file.Delete();
                    }

                    db.SaveChanges();
                    return RedirectToAction("UploadDelivery");
                }

                catch (Exception ex)
                {
                    object mess = "Can not Delete IMG " + ex.Message;
                    return View("Error", mess);
                }
            }

            TempData["Success_Mess"] = "<script>alert('Delete Success')</script>";
            return Redirect("~/Deliveries/UploadDelivery/" + DeliveryId);
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
