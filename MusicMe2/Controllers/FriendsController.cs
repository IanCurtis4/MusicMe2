using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MusicMe2.Controllers
{
    public class FriendsController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Friends
        public ActionResult Index()
        {
            int userId = (int)Session["UserId"];
            var friendSet = db.FriendSet.Include(f => f.ProfileDestinySet).Include(f => f.ProfileOriginSet);
            try
            {

                var friendships = db.FriendSet.Where(p => p.ProfileDestinyId == userId && p.Friended == false).ToList();

                List<Profile> friends = new List<Profile>();

                foreach (var friendship in friendships)
                {
                    List<Profile> friendsOrigin = db.ProfileSet.Where(x => x.ProfileId == friendship.ProfileOriginId).ToList();

                    foreach (var friend in friendsOrigin)
                    {
                        friends.Add(friend);
                    }

                }
                return View(friends.ToList());
            }
            catch (Exception e)
            {
                ViewBag.error = e.ToString();
                return View("Error");
            }
        }

        public ActionResult Accepted()
        {
            int userId = (int)Session["UserId"];
            var friendSet = db.FriendSet.Include(f => f.ProfileDestinySet).Include(f => f.ProfileOriginSet);
            var friendships = db.FriendSet.Where(p => p.ProfileOriginId == userId && p.Friended == true || p.ProfileDestinyId == userId && p.Friended == true).ToList();

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

            return View(friends.ToList());
        }

        // GET: Friends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friend friend = db.FriendSet.Find(id);
            if (friend == null)
            {
                return HttpNotFound();
            }
            return View(friend);
        }

        // GET: Friends/Create
        public ActionResult Create()
        {
            ViewBag.ProfileDestinyId = new SelectList(db.ProfileSet, "ProfileId", "Name");
            return View();
        }

        // POST: Friends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,ProfileDestinyId")] Friend friend)
        {
            if (ModelState.IsValid)
            {
                var userId = (int)Session["UserId"];
                friend.ProfileOriginId = userId;
                friend.Friended = false;
                db.FriendSet.Add(friend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProfileDestinyId = new SelectList(db.ProfileSet, "ProfileId", "Name", friend.ProfileDestinyId);
            return View(friend);
        }



        // POST: Friends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var userId = (int)Session["UserId"];
                var dbFriends = db.FriendSet.Where(p => p.Friended == false);
                foreach (var member in dbFriends)
                {
                    if ((member.ProfileOriginId == userId && member.ProfileDestinyId == id) || (member.ProfileDestinyId == userId && member.ProfileOriginId == id))
                    {
                        Friend friend = db.FriendSet.Find(member.FriendId);
                        friend.Friended = true;
                    }
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: Friends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friend friend = db.FriendSet.Find(id);
            if (friend == null)
            {
                return HttpNotFound();
            }
            return View(friend);
        }

        // POST: Friends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Friend friend = db.FriendSet.Find(id);
            db.FriendSet.Remove(friend);
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
