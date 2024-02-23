using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class AboutController : Controller
    {
        [Route("hakkimizda")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
