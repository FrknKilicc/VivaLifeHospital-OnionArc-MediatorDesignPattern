using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.CommentDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.CommentViewComponents
{
    public class _GetAllCommentViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetAllCommentViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7226/api/Comment");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsontData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsontData);
                return View(values);
            }
            return View(null);
        }
    }
}
