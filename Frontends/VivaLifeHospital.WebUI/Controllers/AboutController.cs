using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class AboutController : Controller
    {
        [Route("Hakkimizda")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
