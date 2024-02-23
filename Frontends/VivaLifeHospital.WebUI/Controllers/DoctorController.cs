using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VivaLifeHospital.Dto.DoctorDtos;

namespace VivaLifeHospital.WebUI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DoctorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
       
        [HttpGet("GetDoctorWithDepartmentBySearch/{id}")]
        public async Task<ActionResult> GetDoctorWithDepartmentBySearch([FromRoute] int id, [FromQuery] string search) // from route & fromquery rootdan al queryden al 
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var uriBuilder = new UriBuilder("https://localhost:7226/api/Doctors/GetDoctorWithDepartmentBySearch");
                var query = $"id={id}&search={search}";
                uriBuilder.Query = query;

                var responseMessage = await client.GetAsync(uriBuilder.Uri);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<List<ResultAllDoctorWithDepartmentDto>>(jsonData);
                    return new JsonResult(value);
                }
                return BadRequest("We Catch Exception, try to find the problem, it'll take a minute...");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
