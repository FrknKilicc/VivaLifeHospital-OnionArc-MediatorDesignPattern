using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.CategoryDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.CategoryViewComponents
{
    public class _GetAllCategoryViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetAllCategoryViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var reponseMessage = await client.GetAsync("https://localhost:7226/api/Category");
            if (reponseMessage.IsSuccessStatusCode && reponseMessage!=null)
            {
                var jsonData= await reponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View(null);
        }
    }
}
