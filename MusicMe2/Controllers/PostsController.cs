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
    public class PostsController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Posts
        public ActionResult Index()
        {
            var userId = (int)Session["UserId"];
            var postSet = db.PostSet.Include(p => p.ProfileSet).Include(p => p.ShareSet).Include(p => p.CommentSet);
            var userPosts = postSet.Where(p => p.ProfileProfileId == userId).ToList();
            List<Post> posts = new List<Post>();
            try
            {
                
                var friendships = db.FriendSet.Where(p => p.ProfileOriginId == userId || p.ProfileDestinyId == userId && p.Friended == true).ToList();

                List<Profile> friends = new List<Profile>();

                foreach (var friendship in friendships)
                {
                    List<Profile> friendsOrigin = db.ProfileSet.Where(x => x.ProfileId == friendship.ProfileOriginId).ToList();
                    if (friendship.ProfileOriginId == userId)
                    {
                        friends = db.ProfileSet.Where(x => x.ProfileId == friendship.ProfileDestinyId).ToList();
                    }
                    else
                    {

                        foreach (var friend in friendsOrigin)
                        {
                            friends.Add(friend);
                        }

                    }
                }
                 
                foreach (var friend in friends)
                {
                    foreach (var share in db.ShareSet.Where(s => s.ProfileProfileId == friend.ProfileId))
                    {
                        foreach (var post in postSet.Where(p => p.ProfileProfileId == friend.ProfileId))
                        {
                            if (share.PostPostId == post.PostId)
                            {
                                posts.Add(post);
                            }
                        }
                    }
                }

                foreach (var friend in friends)
                {
                    foreach (var post in postSet.Where(p => p.ProfileProfileId == friend.ProfileId))
                    {
                        posts.Add(post);
                    }
                }

                foreach (var user in userPosts)
                {
                    posts.Add(user);
                }

            }
            catch (NullReferenceException nullExcep)
            {
                ViewBag.Error = nullExcep.ToString();
                return View("Error");
            }

            
            return View(posts);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.PostSet.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PostId,Text,Midia")] Post post, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                string midiapath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UserMidia/"), postedFile.FileName);
                postedFile.SaveAs(midiapath);
                post.Midia = postedFile.FileName;
                post.ProfileProfileId = (int)Session["UserId"];
                db.PostSet.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.PostSet.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PostId,Text,Midia")] Post post, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                string imgpath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UserMidia/"), postedFile.FileName);
                postedFile.SaveAs(imgpath);
                post.Midia = postedFile.FileName;
                post.ProfileProfileId = (int)Session["UserId"];
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.PostSet.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.PostSet.Find(id);
            db.PostSet.Remove(post);
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
