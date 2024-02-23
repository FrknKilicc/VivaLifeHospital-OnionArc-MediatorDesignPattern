using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class MedicalProgramWithPriceController : Controller
    {
        [Route("fiyatlar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
