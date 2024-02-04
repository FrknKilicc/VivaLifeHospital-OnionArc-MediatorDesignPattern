using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.DepartmentCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> DepartmentList()
        {
            var value = await _mediator.Send(new GetDepartmentQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var value = await _mediator.Send(new GetDepartmentByIdQuery(id));
            return Ok(value);   
        }
        [HttpGet("GetDepartmentWithDoctor/{id}")]
        public async Task<IActionResult> GetDepartmentWithDoctor(int id)
        {
            var value = await _mediator.Send(new GetDepartmentWithDoctorQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartment(CreateDepartmentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Bölüm Bilgisi Başarıyla Eklendi ");
        }
       
        [HttpPut]
        public async Task<IActionResult> UpdateDepartment(UpdateDepartmentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Bölüm Bilgisi Başarıyla Eklendi");

        }
        [HttpDelete]
        public async Task<IActionResult> RemoveDepartment(int id)
        {
            await _mediator.Send(new RemoveDepartmentCommand(id));
            return Ok("Bölüm Bilgisi Başarıyla Silindi");
        }
    }
}
