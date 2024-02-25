using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.ContactCommand;
using VivaLifeHospital.Application.Features.Mediator.Queries.ContactQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VisitorContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var value = await _mediator.Send(new GetVisitorContactQuery());
            return Ok(value);   
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            var value = await _mediator.Send(new GetVisitorContactByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateVisitorContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateVisitorContactCommand command)
        {
            await _mediator.Send(command);
            return Ok("İletişim Bilgisi Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveContact(int id)
        {
            await _mediator.Send(new RemoveVisitorContactCommand(id));
                return Ok("İletişim Bilgisi Başarıyla Silindi");

        }
    }
}
