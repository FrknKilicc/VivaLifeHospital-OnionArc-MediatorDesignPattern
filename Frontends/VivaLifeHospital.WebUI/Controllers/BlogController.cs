using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
