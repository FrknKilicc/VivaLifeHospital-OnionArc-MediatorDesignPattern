using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data.Common;
using System.Text;
using System.Text.Unicode;
using VivaLifeHospital.Dto.BlogDtos;
using VivaLifeHospital.Dto.CommentDtos;

namespace VivaLifeHospital.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public  IActionResult Index()
        {
            return View();
        }
       
        public IActionResult BlogDetail(int id)
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
        [HttpPost]
        public async Task<IActionResult> PostComment(CreateCommentDto createCommentDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCommentDto);
            StringContent content=new StringContent(jsonData,Encoding.UTF8,"application/json"); ;
            var responseMessage = await client.PostAsync("https://localhost:7226/api/Comment",content);
            if(responseMessage.IsSuccessStatusCode && responseMessage != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Sistem Kesintisi Nedeniyle İşleminizi Sıraya Aldık");
        }
    }
}
