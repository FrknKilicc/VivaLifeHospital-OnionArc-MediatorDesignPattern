using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class HealtCareTeamController : Controller
    {
        [Route("saglik-calisanlari")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("doktor-bul")]
        public IActionResult GetFindDoctor()
        {
            return View();

        }
    }
}
