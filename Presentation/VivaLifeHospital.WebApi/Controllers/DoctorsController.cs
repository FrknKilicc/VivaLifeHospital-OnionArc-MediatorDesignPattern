using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.DoctorCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> DoctorList() 
        {
            var values = await _mediator.Send(new GetDoctorQuery());
            return Ok(values);
        }
        [HttpGet("GetAllDrWithDepartment")]
        public async Task<IActionResult> GetAllDrWithDepartment()
        {
            var values = await _mediator.Send(new GetAllDoctorWithDepartmentQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var values = await _mediator.Send(new GetDoctorByIdQuery(id));
            return Ok(values);  
        }
        [HttpPost]
        public async Task<IActionResult> CreateDoctor(CreateDoctorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Doktor Bilgisi Başarıyla Eklendi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Doktor Bilgisi Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveDoctor(int id)
        {
            await _mediator.Send(new RemoveDoctorCommand(id));
            return Ok("Doktor Bilgisi Başarıyla Silindi");
        }
    }
}
