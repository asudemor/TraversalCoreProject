using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class HomepageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
