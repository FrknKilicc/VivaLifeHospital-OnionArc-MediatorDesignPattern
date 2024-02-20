using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.CommentDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.CommentViewComponents
{
    public class _GetCommentByBlogIdViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetCommentByBlogIdViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.Id = id;
            var client =  _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7226/api/Comment/GetCommentByBlogId?id={id}");
            if (responseMessage.IsSuccessStatusCode && responseMessage!=null)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                return View(values);
            }
            return View(null);
        }
    }
}
