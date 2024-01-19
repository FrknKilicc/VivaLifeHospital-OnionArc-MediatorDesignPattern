using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ThemeScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
