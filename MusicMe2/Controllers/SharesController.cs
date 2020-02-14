using System.Web.Mvc;

namespace MusicMe2.Controllers
{
    public class SharesController : Controller
    {
        private Entities1 db = new Entities1();




        // POST: Shares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id)
        {
            int userId = (int)Session["UserId"];
            if (ModelState.IsValid)
            {
                Share share = new Share();
                share.PostPostId = id;
                share.ProfileProfileId = userId;
                db.ShareSet.Add(share);
                Post post = db.PostSet.Find(id);
                post.ShareSet.Add(share);
                db.SaveChanges();
                return RedirectToAction("Index", "Posts", null);
            }
            return RedirectToAction("Index", "Posts", null);
        }

        // POST: Shares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Shares/Delete/{id}/{postId}")]
        public ActionResult DeleteConfirmed(int id, int postId)
        {
            Share share = db.ShareSet.Find(id);
            Post post = db.PostSet.Find(postId);
            post.ShareSet.Remove(share);
            db.ShareSet.Remove(share);
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
