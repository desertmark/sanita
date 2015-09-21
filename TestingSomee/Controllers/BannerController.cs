using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sanita.Models;
using Sanita.Tools;
using System.Drawing;

namespace Sanita.Controllers
{
    [Authorize]
    public class BannerController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Banner/

        public ActionResult Index()
        {
            return View(db.Banners.ToList());
        }

        //
        // GET: /Banner/Details/5

        public ActionResult Details(int id = 0)
        {
            Banner banner = db.Banners.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        //
        // GET: /Banner/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Banner/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UploadImg(string descripcion)
        {
            var Img = Request.Files[0];
            if (Img.ContentLength > 0)
            {
                //Cambiando de tamaño la imagen
                Image Imagen = Image.FromStream(Img.InputStream);
                Imagen = ImageResizer.ResizeBitmap((Bitmap)Imagen, 1000); /// new width
                //Guardando Imagen
                string path = "~/Images/Banners/" + Img.FileName;
                Imagen.Save(Server.MapPath(path));
                //Actualizando BD
                Banner Banner = new Banner();
                Banner.Nombre = Img.FileName;
                Banner.Img = path;
                Banner.Descripcion = descripcion;
                if (ModelState.IsValid)
                {
                    db.Banners.Add(Banner);
                    db.SaveChanges();
                }

            }
            return RedirectToAction("Index");
        }

        //
        // GET: /Banner/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Banner banner = db.Banners.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        //
        // POST: /Banner/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Banner banner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banner);
        }

        //
        // GET: /Banner/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Banner banner = db.Banners.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        //
        // POST: /Banner/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banner banner = db.Banners.Find(id);
            System.IO.FileInfo fi = new System.IO.FileInfo(Server.MapPath(banner.Img));
            fi.Delete();
            db.Banners.Remove(banner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}