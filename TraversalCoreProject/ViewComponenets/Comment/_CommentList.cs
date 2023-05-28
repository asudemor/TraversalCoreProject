using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponenets.Comment
{
    public class _CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
