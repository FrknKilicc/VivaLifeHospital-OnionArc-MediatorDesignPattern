using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.DepartmentDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.DepartmentViewComponents
{
    public class _DepartmentWithDoctorsViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DepartmentWithDoctorsViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.DepId = id;    
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7226/api/Department/GetDepartmentWithDoctor/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultDepartmentDto>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
