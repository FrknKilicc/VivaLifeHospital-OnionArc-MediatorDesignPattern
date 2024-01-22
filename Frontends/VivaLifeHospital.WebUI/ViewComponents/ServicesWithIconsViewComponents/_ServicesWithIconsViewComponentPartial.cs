using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.ServiceDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.ServicesWithIconsViewComponents
{
    public class _ServicesWithIconsViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicesWithIconsViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage =await client.GetAsync("https://localhost:7226/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(JsonData);
                return View(values);
            }
            return View();
        }
    }
}
