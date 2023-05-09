using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponenets.Homepage
{
    public class _SliderPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
