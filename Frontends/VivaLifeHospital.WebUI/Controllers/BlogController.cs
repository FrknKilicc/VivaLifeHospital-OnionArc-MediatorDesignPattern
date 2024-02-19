using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public async Task<IActionResult>  Index()
        {
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
