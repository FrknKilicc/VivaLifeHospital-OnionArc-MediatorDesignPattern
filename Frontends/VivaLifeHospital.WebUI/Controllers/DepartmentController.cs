using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using VivaLifeHospital.Dto.DepartmentDtos;

namespace VivaLifeHospital.WebUI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IHttpClientFactory _httpClientFactory;
        public DepartmentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet("GetDoctorWithDepartment/{departmanId}")]
        public async Task<JsonResult> GetDoctorWithDepartment(int departmanId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7226/api/Department/GetDepartmentWithDoctor/{departmanId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultDepartmentDto>>(jsonData);
                return new JsonResult(value);
            }
            return new JsonResult(null);
        }
    }
}
