using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponenets.Homepage
{
    public class _SubAboutPartial : ViewComponent
    {
        SubAboutManager subaboutManager = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subaboutManager.TGetList();
            return View(values);
        }
    }
}