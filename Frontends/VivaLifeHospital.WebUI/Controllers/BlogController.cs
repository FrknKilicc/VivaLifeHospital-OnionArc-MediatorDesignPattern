using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.BlogDtos;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult>  Index()
        {
            return View();
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpGet("GetBlogBySearchKeyword")]
        public async Task<IActionResult> GetBlogBySearchKeyword(string keyword)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage= await client.GetAsync($"https://localhost:7226/api/Blog/GetBlogBySearch?keyword={keyword}");
            if (responseMessage.IsSuccessStatusCode && responseMessage !=null)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogByIdWithAuthorDto>>(jsonData);
                return Ok(values);
            }
            return BadRequest("Geçersiz İstek");
        }
    }
}
