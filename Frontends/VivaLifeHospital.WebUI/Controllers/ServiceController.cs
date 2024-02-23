using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        [Route("hizmetler")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
