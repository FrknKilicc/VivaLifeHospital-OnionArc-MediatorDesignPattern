using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using VivaLifeHospital.Dto.AppointmentDto;


namespace VivaLifeHospital.WebUI.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AppointmentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PostAppointment(CreateAppointmentDto createAppointmentDto)
        {
            var client= _httpClientFactory.CreateClient();
            var jsonData= JsonConvert.SerializeObject(createAppointmentDto);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7226/api/Appointments",content);
            if (responseMessage != null && responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Bir Hata Oluştu");
            }
        }
    }
}
