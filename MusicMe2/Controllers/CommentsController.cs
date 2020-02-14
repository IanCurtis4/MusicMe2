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
    public class CommentsController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Comments
        public ActionResult Index(int id)
        {
            
            var commentSet = db.CommentSet.Include(c => c.PostSet).Include(c => c.ProfileSet).Where(p => p.PostPostId == id);
            return View(commentSet.ToList());
        }

        

        // GET: Comments/Create
        public ActionResult Create(int id)
        {
            Session["CommentPost"] = id;
            return View();
        }

        // POST: Comments/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CommentId,Text")] Comment comment, int id)
        {
            var profileId = (int)Session["UserId"];
            if (ModelState.IsValid)
            {
                comment.ProfileProfileId = profileId;
                comment.PostPostId = id;
                var post = db.PostSet.Find(id);
                post.CommentSet.Add(comment);
                db.CommentSet.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index", "Posts", null);
            }

            return RedirectToAction("Index", "Posts", null);
        }

        // GET: Comments/Edit/5
        public ActionResult Edit(int? id)
        {
            var profileId = (int)Session["UserId"];
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.CommentSet.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Comments/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CommentId,Text")] Comment comment)
        {
            var profileId = (int)Session["UserId"];
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Posts", null);
        }

        // GET: Comments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.CommentSet.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.CommentSet.Find(id);
            db.CommentSet.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index", "Posts", null);
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
