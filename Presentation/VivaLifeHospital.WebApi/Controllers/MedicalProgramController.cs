using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.MedicalProgramCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.MedicalProgramQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalProgramController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MedicalProgramController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> MedicalProgramList()
        {
            var value = await _mediator.Send(new GetMedicalProgramQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedicalById(int id)
        {
            var value = await _mediator.Send(new GetMedicalProgramByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMedicalProgram(CreateMedicalProgramCommand command)
        {
            await _mediator.Send(command);
            return Ok("Bilgi Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMedicalProgram(UpdateMedicalProgramCommand command)
        {
            await _mediator.Send(command);
            return Ok("Bilgi Başarıyla Güncellendi");

        }
        [HttpDelete]
        public async Task<IActionResult> RemoveMedicalProgram(int id)
        {
            await _mediator.Send(new RemoveMedicalProgramCommand(id));
            return Ok("Bilgi Başarıyla Silindi");
        }
    }
}
