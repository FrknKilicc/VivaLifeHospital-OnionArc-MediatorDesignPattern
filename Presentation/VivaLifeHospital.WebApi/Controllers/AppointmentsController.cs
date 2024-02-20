using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.AppointmentCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.AppointmentQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public AppointmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AppointmentList()
        {
            var values = await _mediator.Send(new GetAppointmentQuery());
            return Ok(values);
            
            
        }
        [HttpPost]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Randevu Kayıt İşlemi Başarıyla Gerçekleşti.");

        }
    }
}
