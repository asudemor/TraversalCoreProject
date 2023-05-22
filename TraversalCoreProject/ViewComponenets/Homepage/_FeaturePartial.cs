using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponenets.Homepage
{
    public class _FeaturePartial : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            return View();
        } 
    }
}
