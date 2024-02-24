using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.ViewComponents.AjaxndJQueryViewComponents
{
    public class _AjaxNdJQueryViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
