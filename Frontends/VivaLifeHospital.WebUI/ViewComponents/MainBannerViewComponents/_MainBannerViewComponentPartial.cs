using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.BannerDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.MainBannerViewComponents
{
    public class _MainBannerViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _MainBannerViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7226/api/Banner");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBannerDto>>(JsonData);
                return View(values);
            }
            return View();
        }
    }
}
