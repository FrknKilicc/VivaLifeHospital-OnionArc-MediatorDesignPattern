using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.DoctorDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.HealthCareTeamViewComponents
{
    public class _HealthCareProfViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HealthCareProfViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7226/api/Doctors/GetAllDrWithDepartment");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllDoctorWithDepartmentDto>>(jsonData);
                return View(values);
            }
            return View();
        }




      
    }
}
