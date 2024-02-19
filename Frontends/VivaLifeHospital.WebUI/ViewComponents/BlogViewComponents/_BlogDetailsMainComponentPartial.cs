using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.BlogDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailsMainComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.Id = id;
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7226/api/Blog/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData= await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultBlogDto>(jsonData);
                return View(value);
            }
            return View(null);
        }
    }
}
