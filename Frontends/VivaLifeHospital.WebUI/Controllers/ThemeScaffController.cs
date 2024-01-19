using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class ThemeScaffController : Controller
    {
        public IActionResult Scaff()
        {
            return View();
        }
    }
}
