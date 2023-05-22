using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponenets.Homepage
{
    public class _TestimonialPartial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new  EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}