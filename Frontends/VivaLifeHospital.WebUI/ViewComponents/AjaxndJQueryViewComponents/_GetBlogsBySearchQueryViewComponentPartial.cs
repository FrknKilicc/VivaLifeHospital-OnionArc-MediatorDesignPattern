using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.ViewComponents.AjaxndJQueryViewComponents
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
