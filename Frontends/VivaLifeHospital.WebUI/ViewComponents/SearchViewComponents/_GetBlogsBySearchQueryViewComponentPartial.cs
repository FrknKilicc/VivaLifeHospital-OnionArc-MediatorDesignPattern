using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.BlogDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.SearchViewComponents
{
    public class _GetBlogsBySearchQueryViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetBlogsBySearchQueryViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IViewComponentResult Invoke()
        {
          return View();
        }
    }
}
