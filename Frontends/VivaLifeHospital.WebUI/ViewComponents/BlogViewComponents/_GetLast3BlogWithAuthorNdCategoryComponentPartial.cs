using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.BlogDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.BlogViewComponents
{
    public class _GetLast3BlogWithAuthorNdCategoryComponentPartial:ViewComponent
    {
        private IHttpClientFactory _httpClientFactory;


        public _GetLast3BlogWithAuthorNdCategoryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client =  _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7226/api/Blog/GetLast3Blog");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject <List<ResultBlogDto>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
