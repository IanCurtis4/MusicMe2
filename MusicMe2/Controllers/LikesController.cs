using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicMe2.Controllers
{
    public class LikesController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: Likes
        public ActionResult Index()
        {
            var likeSet = db.LikeSet.Include(l => l.CommentSet).Include(l => l.MusicSet).Include(l => l.PlaylistSet).Include(l => l.ProfileSet).Include(l => l.Post);
            return View(likeSet.ToList());
        }



        // POST: Likes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id)
        {

            int userId = (int)Session["UserId"];
            Like like = new Like();
            if (ModelState.IsValid)
            {
                like.Liked = "Sim";
                like.CommentCommentId = null;
                like.PostPostId = id;
                like.ProfileProfileId = userId;
                db.LikeSet.Add(like);
                Post post = db.PostSet.Find(id);
                post.Like.Add(like);
                db.SaveChanges();

                return RedirectToAction("Index", "Posts", null);
            }

            return RedirectToAction("Index", "Posts", null);
        }

        // POST: Likes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int postId)
        {
            Like like = db.LikeSet.Find(id);
            db.LikeSet.Remove(like);
            Post post = db.PostSet.Find(postId);
            post.Like.Remove(like);
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
