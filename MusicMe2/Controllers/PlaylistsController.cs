using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicMe2;

namespace MusicMe2.Controllers
{
    public class PlaylistsController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Playlists
        public ActionResult Index()
        {
            var playlistSet = db.PlaylistSet.Include(p => p.ProfileSet);
            return View(playlistSet.ToList());
        }

        // GET: Playlists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Playlist playlist = db.PlaylistSet.Find(id);
            if (playlist == null)
            {
                return HttpNotFound();
            }
            return View(playlist);
        }

        // GET: Playlists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Playlists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlaylistId,Name")] Playlist playlist)
        {
            if (ModelState.IsValid)
            {
                playlist.ProfileProfileId = (int)Session["UserId"];
                db.PlaylistSet.Add(playlist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(playlist);
        }

        // GET: Playlists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Playlist playlist = db.PlaylistSet.Find(id);
            if (playlist == null)
            {
                return HttpNotFound();
            }
            return View(playlist);
        }

        // POST: Playlists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlaylistId,Name")] Playlist playlist)
        {
            if (ModelState.IsValid)
            {
                //playlist.MusicSet.
                db.Entry(playlist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playlist);
        }

        public ActionResult AddMusic(int id)
        {
            Playlist playlist = db.PlaylistSet.Find(id);
            var userId = (int)Session["UserId"];
            ViewBag.MusicMusicId = new SelectList(db.MusicSet.Where(p => p.ProfileProfileId == userId), "MusicId", "Name");
            return View(playlist);
        }

        [HttpPost]
        public ActionResult AddMusic([Bind(Include = "PlaylistId,Name")] Playlist playlist, int id)
        {
            if (ModelState.IsValid)
            {
                //playlist.MusicSet.
                Music music = db.MusicSet.Find(id);
                playlist.MusicSet.Add(music);
                db.Entry(playlist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Playlists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Playlist playlist = db.PlaylistSet.Find(id);
            if (playlist == null)
            {
                return HttpNotFound();
            }
            return View(playlist);
        }

        // POST: Playlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Playlist playlist = db.PlaylistSet.Find(id);
            db.PlaylistSet.Remove(playlist);
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
