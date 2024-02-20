using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.TagCloudDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.TagsCloudViewComponents
{
    public class _GetTagsCloudViewComponentPartial:ViewComponent
    {
        private readonly   IHttpClientFactory _httpClientFactory;

        public _GetTagsCloudViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.Id = id;    
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7226/api/TagsCloud/TagsCloudByBlogId?id={id}");
            if (responseMessage.IsSuccessStatusCode && responseMessage!=null)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTagCloud>>(jsonData);
                return View(values);
            }
            return View(null);
        }
    }
}
