using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VivaLifeHospital.Dto.ContactDtos;

namespace VivaLifeHospital.WebUI.ViewComponents.ContactViewComponents
{
    public class _GetContactListViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _GetContactListViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7226/api/Contacts");
            if (responseMessage.IsSuccessStatusCode && responseMessage !=null)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(values) ;
            }
            return View(null);
        }

        //
    }
}
