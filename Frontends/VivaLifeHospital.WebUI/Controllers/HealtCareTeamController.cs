using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class HealtCareTeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult GetFindDoctor()
        {
            return View();

        }
    }
}
