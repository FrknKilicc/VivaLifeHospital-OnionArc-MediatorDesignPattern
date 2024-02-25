using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.ViewComponents.AjaxndJQueryViewComponents
{
    public class _GetDoctorListByDepartmentViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetDoctorListByDepartmentViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
