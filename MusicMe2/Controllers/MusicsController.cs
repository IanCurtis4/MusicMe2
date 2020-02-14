using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicMe2;

namespace MusicMe2.Controllers
{
    public class MusicsController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Musics
        public ActionResult Index()
        {
            var musicSet = db.MusicSet.Include(m => m.ProfileSet);
            return View(musicSet.ToList());
        }

        // GET: Musics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.MusicSet.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // GET: Musics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Musics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusicId,Name,Band,Album")] Music music, HttpPostedFileBase postedFile)
        {

            var userId = (int)Session["UserId"];
            if (ModelState.IsValid)
            {
                string imgpath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UserMidia/"), postedFile.FileName);
                postedFile.SaveAs(imgpath);
                music.Midia = postedFile.FileName;
                music.ProfileProfileId = userId;
                db.MusicSet.Add(music);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(music);
        }

        // GET: Musics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.MusicSet.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // POST: Musics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusicId,Name,Band,Album")] Music music, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                string imgpath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UserMidia/"), postedFile.FileName);
                postedFile.SaveAs(imgpath);
                music.Midia = postedFile.FileName;
                music.ProfileProfileId = (int)Session["UserId"];
                db.Entry(music).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(music);
        }

        // GET: Musics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.MusicSet.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // POST: Musics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Music music = db.MusicSet.Find(id);
            db.MusicSet.Remove(music);
            db.SaveChanges();
            return RedirectToAction("Index");
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
