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
using MusicMe2.Models;

namespace MusicMe2.Controllers
{
    public class ProfilesController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Profiles
        public ActionResult Index()
        {
            return View(db.ProfileSet.ToList());
        }

        // GET: Profiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.ProfileSet.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // GET: Profiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProfileId,Name,Gender,Country,BirthDate,Email")] Profile profile, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                string imgpath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UserImages/"), postedFile.FileName);
                postedFile.SaveAs(imgpath);
                profile.ProfilePicture = postedFile.FileName;
                profile.Email = (string)Session["UserEmail"];
                db.ProfileSet.Add(profile);
                db.SaveChanges();
                Session["UserId"] = profile.ProfileId;
                return RedirectToAction("Details", new { id = (int)Session["UserId"] });
            }

            return View(profile);
        }

        // GET: Profiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.ProfileSet.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProfileId,Name,Gender,Country,ProfilePicture,BirthDate")] Profile profile, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                string imgpath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UserImages/"), postedFile.FileName);
                postedFile.SaveAs(imgpath);
                profile.ProfilePicture = postedFile.FileName;
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        // GET: Profiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.ProfileSet.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profile profile = db.ProfileSet.Find(id);
            db.ProfileSet.Remove(profile);
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

        public ActionResult Search()
        {
            return View(db.ProfileSet.ToList());
        }

        [HttpPost]
        public ActionResult Search(string search)
        {
            List<Profile> profiles = new List<Profile>();
            foreach (var item in db.ProfileSet)
            {
                if (item.Name.Contains(search))
                {
                    profiles.Add(item);
                }
            }

            return View(profiles);
        }
    }
}
