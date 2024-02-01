using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.BlogDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogListViewComponentPartial: ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;

        public _BlogListViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7226/api/Blog");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultBlogDto>>(JsonData);
                return View(value);

            }
            return View();
        }
    }
}
