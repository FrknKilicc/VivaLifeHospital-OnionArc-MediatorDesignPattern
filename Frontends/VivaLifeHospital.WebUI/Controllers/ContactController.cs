using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class ContactController : Controller
    {
        [Route("iletisim")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
